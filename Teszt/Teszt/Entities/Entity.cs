using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Teszt
{
    /// <summary>
    /// This is the interface for all Entity classes from the DB.
    /// </summary>
    abstract public class Entity
    {
        /// <summary>
        /// The model entity will be created in the Database.
        /// </summary>
        abstract public void CreateItself();
        /// <summary>
        /// The model entity will be updated in the Database.
        /// </summary>
        abstract public void UpdateItself();
        /// <summary>
        /// The model entity will be deleted from the Databse.
        /// </summary>
        abstract public void DeleteItself();
        /// <summary>
        /// Some validation must be declare here.
        /// </summary>
        abstract public void Validation();
        /// <summary>
        /// Some validation must be declare here.
        /// </summary>
        public string ToCSVFormat()
        {
            StringBuilder sb = new StringBuilder();

            Type type = this.GetType();

            PropertyInfo[] properties = type.GetProperties();

            sb.Append(this.GetType().Name);
            sb.Append(";");

            for (int i = 0; i < properties.Length - 1; i++)
            {
                string value = Convert.ToString(properties[i].GetValue(this));
                sb.Append($"{value};");
            }
            sb.Append($"{properties[properties.Length - 1].GetValue(this)}");

            return sb.ToString();

        }

        public List<Control> GetEntityViewControls()
        {
            List<Control> controls = new List<Control>();

            Type type = this.GetType();
            int labelWidth = 60;
            int txtWidth = 100;
            int sormagassag = 25;

            PropertyInfo[] properties = type.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                Label lbl_Entity = new Label();
                lbl_Entity.Name = $"lbl_{type.Name}_{properties[i]}";
                lbl_Entity.Text = properties[i].Name;
                lbl_Entity.Location = new System.Drawing.Point(10, (i + 1) * sormagassag);
                lbl_Entity.Width = labelWidth;
                controls.Add(lbl_Entity);

                TextBox txt_Entity = new TextBox();
                lbl_Entity.Name = $"txt_{type.Name}_{properties[i]}";
                txt_Entity.Text = properties[i].GetValue(this).ToString();
                txt_Entity.Enabled = true;
                txt_Entity.Width = txtWidth;
                txt_Entity.Location = new System.Drawing.Point(labelWidth + 10, (i + 1) * sormagassag);
                controls.Add(txt_Entity);
            }

            return controls;

        }
    }
}
