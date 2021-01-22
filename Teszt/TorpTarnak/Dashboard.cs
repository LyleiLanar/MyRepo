using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Teszt;
using Teszt.Entities;

namespace TorpTarnak
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            ComboBox_Entities.DataSource = new String[] { "Törpök", "Kőzetek", "Tárnák" };
            ComboBox_Entities.DisplayMember = "Törpök";
            Fill_ListBox_Entities();
        }


        public void Fill_ListBox_Entities()
        {
            bool isSearched = false;

            if (this.textBox_SearchField.Text.Length != 0)
            {
                isSearched = true;
            }

            switch (ComboBox_Entities.SelectedValue)
            {
                case "Törpök":
                    if (isSearched)
                    {
                        List<Torpe> torpek = Torpe.GetAllByNameFrag(textBox_SearchField.Text);

                        if (torpek != null)
                        {
                            this.ListBox_Entities.DataSource = torpek.ToArray();
                        }
                        else
                        {
                            this.ListBox_Entities.DataSource = null;
                        }
                    }
                    else

                    {
                        this.ListBox_Entities.DataSource = Torpe.GetAll().ToArray();
                    }

                    ListBox_Entities.DisplayMember = "Nev";
                    break;

                case "Kőzetek":
                    this.ListBox_Entities.DataSource = Kozet.GetAll().ToArray();
                    ListBox_Entities.DisplayMember = "Nev";
                    break;

                case "Tárnák":
                    this.ListBox_Entities.DataSource = Tarna.GetAll().ToArray();
                    ListBox_Entities.DisplayMember = "Nev";
                    break;

                case "Kihol":
                    this.ListBox_Entities.DataSource = Tarna.GetAll().ToArray();
                    ListBox_Entities.DisplayMember = "Nev";
                    break;


                default:
                    throw new Exception("Nincs ilyen entity!!!");
            }
        }


        private void ComboBox_Entities_SelectedValueChanged(object sender, EventArgs e)
        {
            Fill_ListBox_Entities();
        }

        private void button_SrchOk_Click(object sender, EventArgs e)
        {
            Fill_ListBox_Entities();
        }

        private void ListBox_Entities_SelectedValueChanged(object sender, EventArgs e)
        {
            groupBox_Details.Controls.Clear();
            groupBox_Details.Width = 260;
            groupBox_Details.Text = "Details";

            if (ListBox_Entities.SelectedValue != null)

            {
                switch (ComboBox_Entities.SelectedValue)
                {
                    case "Törpök":

                        Torpe torpe = (Torpe)ListBox_Entities.SelectedValue;
                        groupBox_Details.Controls.AddRange(torpe.GetEntityViewControls().ToArray());
                        break;

                    case "Kőzetek":

                        Kozet kozet = (Kozet)ListBox_Entities.SelectedValue;
                        groupBox_Details.Controls.AddRange(kozet.GetEntityViewControls().ToArray());
                        break;

                    case "Tárnák":

                        Tarna tarna = (Tarna)ListBox_Entities.SelectedValue;
                        groupBox_Details.Controls.AddRange(tarna.GetEntityViewControls().ToArray());
                        break;


                    default:
                        throw new Exception("Nincs ilyen entity!!!");
                }
            }
        }
    }
}
