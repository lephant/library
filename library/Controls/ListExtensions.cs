using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace library.Controls
{
    public static class ListExtension
    {
        /// <summary>
        /// Преобразование списка данных в таблицу 
        /// </summary>
        /// <typeparam name="T">Тип данных, содержащихся в списке</typeparam>
        /// <param name="list">Список, содержащий некоторые данные</param>
        /// <returns></returns>
        public static DataTable ToTable<T>(this IEnumerable<T> list)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            for (var i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                for (var i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
