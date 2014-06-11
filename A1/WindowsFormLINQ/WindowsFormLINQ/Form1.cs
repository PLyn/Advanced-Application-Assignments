/*
 Student Name: Peter Lyn
 Student ID:  26100068
 
 Student Name: Kevin K. Kennedy
 Student ID: 26100087
 
 Course: Advance Application Development (CPTR465)
 Instructor: Mr. Damion R. Mitchell (Assistant Professor, M.Sc.)
 University: Northern Caribbean University
 Department: Computer and Information Sciences
 Programming Assignment #:1
 Assignment Ojective: LINQ to SQL using C# Forms
 Due Date: Sunday, May 25, 2014 
 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLINQ
{
    public partial class baseForm : Form
    {
        public baseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             createRecord();
        }


        /*
          Method Name:  createRecord
          Accessibility: private
          Description ==  method to insert a new record in the SQL Server database via LINQ to SQL Classes.
          (Arguments) -> return type ==  (empty) -> void
          Precondition == none
          Postcondition == none
        */

        private void createRecord()
        {
            try
            {

                CSLabDBDataContext cs = new CSLabDBDataContext();

                var stock = new CSLabStock
                {
                    NCUTag = Convert.ToInt16(TextBoxNCUTag.Text.ToString()),
                    ItemType = TextBoxItemType.Text.ToString(),
                    Quantity = Convert.ToInt16(TextBoxQuantity.Text.ToString()),
                    Manufacturer = TextBoxManufacturer.Text.ToString(),
                    Model = TextBoxModel.Text.ToString(),
                    SerialNum = TextBoxSerial.Text.ToString(),
                    ServiceTag = TextBoxServiceTag.Text.ToString(),
                    Location = TextBoxLocation.Text.ToString(),
                    Status = TextBoxStatus.Text.ToString(),
                    Notes = TextBoxNotes.Text.ToString(),

                };


                cs.CSLabStocks.InsertOnSubmit(stock);
                cs.SubmitChanges();

                foreach (TextBox c in tabControlMain.SelectedTab.Controls.OfType<TextBox>()) /*Clears Textbook After a CRUD operation*/
                {
                    c.Text = "";
                }
                MessageBox.Show("Record Was Sucessfully Created", "Create Status");
            }//end of try

            catch (Exception ex)
            {

                MessageBox.Show("Record Was Unsuccessfully Created..." + Environment.NewLine + ex.Message, "Error Report");
            }//end catch
        }

        private void labelManufacturer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            listAllRecords();
        }

        /*
          Method Name: listAllRecords
          Accessibility: private
          Description == method that list all records in the database via LINQ to SQL Classes
          (Arguments) -> return type == (empty) -> void
          Precondition == none
          Postcondition == none
        
        */

        private void listAllRecords()
        {
            try
            {
                CSLabDBDataContext cs = new CSLabDBDataContext(); /*Clears Textbook After a CRUD operation*/

                var stock = from s in cs.CSLabStocks
                            select s;
                ViewDataGrid.DataSource = stock;


            }//end of try

            catch (Exception ex)
            {

                MessageBox.Show("An Error Occured While Reading the Database.." + Environment.NewLine + ex.Message, "Error Report");
            }//end catch
        }

        private void button3_Click(object sender, EventArgs e)
        {


            searchRecord();

        }

        /*
          Method Name: searchRecord
          Accessibility: private
          Description == Method that displays a record that possess a specific key via LINQ to SQL classes
          (Arguments) -> return type == (empty) -> void
          Precondition == none
          Postcondition == none
         
        */

        private void searchRecord()
        {
            try
            {
                CSLabDBDataContext cs = new CSLabDBDataContext();

                var stock = cs.CSLabStocks.Where(c => c.NCUTag == Convert.ToInt16(TextBoxSearch.Text.ToString()));

                ViewDataGrid.DataSource = stock;


            }//end of try

            catch (Exception ex)
            {

                MessageBox.Show("An Error Occured in The Search Query" + Environment.NewLine + ex.Message, "Error Report");
            }//end catch

            finally
            {

                foreach (TextBox c in tabControlMain.SelectedTab.Controls.OfType<TextBox>())
                {
                    c.Text = "";
                }


            }//end finally
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            updateRecord();
           
        }


        /*
          Method Name: updateRecord
          Accessibility: private
          Description == Method that updates a record that possess a specific key via LINQ to SQL classes
          (Arguments) -> return type == (empty) -> void
          Precondition == none
          Postcondition == none
         
        */


        private void updateRecord()
        {
            try
            {
                CSLabDBDataContext cs = new CSLabDBDataContext();

                CSLabStock stock = cs.CSLabStocks.Single(c => c.NCUTag == Convert.ToInt16(TextBoxNCUTagUpdate.Text.ToString()));

                if (TextBoxItemTypeUpdate.Text.ToString() != "")
                {
                    stock.ItemType = TextBoxItemTypeUpdate.Text.ToString();
                }//end if


                if (TextBoxQuantityUpdate.Text.ToString() != "")
                {
                    stock.Quantity = Convert.ToInt16(TextBoxQuantityUpdate.Text.ToString());
                }//end if

                if (TextBoxManufacturerUpdate.Text.ToString() != "")
                {
                    stock.Manufacturer = TextBoxManufacturerUpdate.Text.ToString();
                }//end if


                if (TextBoxModelUpdate.Text.ToString() != "")
                {
                    stock.Model = TextBoxModelUpdate.Text.ToString();
                }//end if


                if (TextBoxSerialNumberUpdate.Text.ToString() != "")
                {
                    stock.SerialNum = TextBoxSerialNumberUpdate.Text.ToString();
                }//end if


                if (TextBoxServiceTagUpdate.Text.ToString() != "")
                {
                    stock.ServiceTag = TextBoxItemTypeUpdate.Text.ToString();
                }//end if


                if (TextBoxLocationUpdate.Text.ToString() != "")
                {
                    stock.Location = TextBoxServiceTagUpdate.Text.ToString();
                }//end if

                if (TextBoxStatusUpdate.Text.ToString() != "")
                {
                    stock.Status = TextBoxStatusUpdate.Text.ToString();
                }//end if


                if (TextBoxNotesUpdate.Text.ToString() != "")
                {
                    stock.Notes = TextBoxNotesUpdate.Text.ToString();

                }//end if

                cs.SubmitChanges();
                foreach (TextBox c in tabControlMain.SelectedTab.Controls.OfType<TextBox>())
                {
                    c.Text = "";
                }//end foreach

                MessageBox.Show("Record Was Sucessfully Updated", "Update Status");


            }//end of try

            catch (Exception ex)
            {

                MessageBox.Show("An Error Occured in The Upate Query" + Environment.NewLine + ex.Message, "Error Report");
            }//end catch


        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            deleteRecord();

        }

        /*
          Method Name: deleteRecord
          Accessibility: private
          Description == Method that deletes a record that possess a specific key via LINQ to SQL classes
          (Arguments) -> return type == (empty) -> void
          Precondition == none
          Postcondition == none
         
        */

        private void deleteRecord()
        {
            try
            {
                CSLabDBDataContext cs = new CSLabDBDataContext();

                CSLabStock stock = cs.CSLabStocks.Single(c => c.NCUTag == Convert.ToInt16(TextBoxRecordTag.Text.ToString()));

                cs.CSLabStocks.DeleteOnSubmit(stock);

                cs.SubmitChanges();

                foreach (TextBox c in tabControlMain.SelectedTab.Controls.OfType<TextBox>()) /*Clears Textbook After a CRUD operation*/
                {
                    c.Text = "";
                }//end for


                MessageBox.Show("Record Was Sucessfully Deleted", "Delete Status");

            }//end of try

            catch (Exception ex)
            {

                MessageBox.Show("An Error Occured in The Delete Query" + Environment.NewLine + ex.Message, "Error Report");
            }//end catch
        }

        private void pictureBoxWelcome_Click(object sender, EventArgs e)
        {

        }

        private void tabPageWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_hover(object sender, EventArgs e)
        {
            ToolTip MyToolTip = new ToolTip();
            MyToolTip.Show("Click To Create New Record", buttonCreate);
        }

        private void listHover(object sender, EventArgs e)
        {
            ToolTip MyToolTip = new ToolTip();
            MyToolTip.Show("List  All Items In The Inventory", button2);
        }

        private void searchHover(object sender, EventArgs e)
        {
            ToolTip MyToolTip = new ToolTip();
            MyToolTip.Show("Click To Search Inventory ", button3);
        }

        private void updateHover(object sender, EventArgs e)
        {
            ToolTip MyToolTip = new ToolTip();
            MyToolTip.Show("Click To Search Inventory ", buttonUpdate);
        }

        private void deleteHover(object sender, EventArgs e)
        {
            ToolTip MyToolTip = new ToolTip();
            MyToolTip.Show("Click To Delete Inventory ", ButtonDelete);
        }
    }
}
