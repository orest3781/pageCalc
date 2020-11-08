using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pageCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Total_Click(object sender, EventArgs e)
        {
            
            int cbox1a = Convert.ToInt32(box1a.Text);

            int cbox1b = Convert.ToInt32(box1b.Text);

            int cbox2a = Convert.ToInt32(box2a.Text);

            int cbox2b = Convert.ToInt32(box2b.Text);

            int cbox3a = Convert.ToInt32(box3a.Text);

            int cbox3b = Convert.ToInt32(box3b.Text);

            int cbox4a = Convert.ToInt32(box4a.Text);

            int cbox4b = Convert.ToInt32(box4b.Text);

            int cbox5a = Convert.ToInt32(box5a.Text);

            int cbox5b = Convert.ToInt32(box5b.Text);

            int cdoc1a = Convert.ToInt32(doc1a.Text);

            int cdoc1b = Convert.ToInt32(doc1b.Text);

            int cdoc2a = Convert.ToInt32(doc2a.Text);

            int cdoc2b = Convert.ToInt32(doc2b.Text);

            int cdoc3a = Convert.ToInt32(doc3a.Text);

            int cdoc3b = Convert.ToInt32(doc3b.Text);

            int cdoc4a = Convert.ToInt32(doc4a.Text);

            int cdoc4b = Convert.ToInt32(doc4b.Text);

            int cdoc5a = Convert.ToInt32(doc5a.Text);

            int cdoc5b = Convert.ToInt32(doc5b.Text);

            int cov1a = Convert.ToInt32(ov1a.Text);

            int cov1b = Convert.ToInt32(ov1b.Text);

            int cov2a = Convert.ToInt32(ov2a.Text);

            int cov2b = Convert.ToInt32(ov2b.Text);

            int cov3a = Convert.ToInt32(ov3a.Text);

            int cov3b = Convert.ToInt32(ov3b.Text);

            int cov4a = Convert.ToInt32(ov4a.Text);

            int cov4b = Convert.ToInt32(ov4b.Text);

            int cov5a = Convert.ToInt32(ov5a.Text);

            int cov5b = Convert.ToInt32(ov5b.Text);

                                                                              
            int added = cbox1a + cbox1b + cbox2a + cbox2b + cbox3a + cbox3b + cbox4a + cbox4b + cbox5a + cbox5b;
            int docAdded = cdoc1a + cdoc1b + cdoc2a + cdoc2b + cdoc3a + cdoc3b + cdoc4a + cdoc4b + cdoc5a + cdoc5b;
            int overage = cov1a + cov1b + cov2a + cov2b + cov3a + cov3b + cov4a + cov4b + cov5a + cov5b;


            totalPages.Text = Convert.ToString(added);
            totalDocs.Text = Convert.ToString(docAdded);
            overagebox.Text = Convert.ToString(overage);
        }

        private void box1a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box1a.Text, out parsedValue))
            {
                box1a.BackColor = Color.Red;
            }
            else
            {
                box1a.BackColor = Color.White;
            }
                      
            
        }

        private void box1b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box1b.Text, out parsedValue))
            {
                box1b.BackColor = Color.Red;
            }
            else
            {
                box1b.BackColor = Color.White;
            }
        }

        private void box2a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box2a.Text, out parsedValue))
            {
                box2a.BackColor = Color.Red;
            }
            else
            {
                box2a.BackColor = Color.White;
            }
        }

        private void box2b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box2b.Text, out parsedValue))
            {
                box2b.BackColor = Color.Red;
            }
            else
            {
                box2b.BackColor = Color.White;
            }
        }

        private void box3a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box3a.Text, out parsedValue))
            {
                box3a.BackColor = Color.Red;
            }
            else
            {
                box3a.BackColor = Color.White;
            }
        }

        private void box3b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box3b.Text, out parsedValue))
            {
                box3b.BackColor = Color.Red;
            }
            else
            {
                box3b.BackColor = Color.White;
            }
        }

        private void box4a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box4a.Text, out parsedValue))
            {
                box4a.BackColor = Color.Red;
            }
            else
            {
                box4a.BackColor = Color.White;
            }
        }

        private void box4b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box4b.Text, out parsedValue))
            {
                box4b.BackColor = Color.Red;
            }
            else
            {
                box4b.BackColor = Color.White;
            }
        }

        private void box5a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box5a.Text, out parsedValue))
            {
                box5a.BackColor = Color.Red;
            }
            else
            {
                box5a.BackColor = Color.White;
            }
        }

        private void box5b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(box5b.Text, out parsedValue))
            {
                box5b.BackColor = Color.Red;
            }
            else
            {
                box5b.BackColor = Color.White;
            }
        }

        private void doc1a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc1a.Text, out parsedValue))
            {
                doc1a.BackColor = Color.Red;
            }
            else
            {
                doc1a.BackColor = Color.White;
            }
        }

        private void doc1b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc1b.Text, out parsedValue))
            {
                doc1b.BackColor = Color.Red;
            }
            else
            {
                doc1b.BackColor = Color.White;
            }
        }

        private void doc2a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc2a.Text, out parsedValue))
            {
                doc2a.BackColor = Color.Red;
            }
            else
            {
                doc2a.BackColor = Color.White;
            }
        }

        private void doc2b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc2b.Text, out parsedValue))
            {
                doc2b.BackColor = Color.Red;
            }
            else
            {
                doc2b.BackColor = Color.White;
            }
        }

        private void doc3a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc3a.Text, out parsedValue))
            {
                doc3a.BackColor = Color.Red;
            }
            else
            {
                doc3a.BackColor = Color.White;
            }
        }

        private void doc3b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc3b.Text, out parsedValue))
            {
                doc3b.BackColor = Color.Red;
            }
            else
            {
                doc3b.BackColor = Color.White;
            }
        }

        private void doc4a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc4a.Text, out parsedValue))
            {
                doc4a.BackColor = Color.Red;
            }
            else
            {
                doc4a.BackColor = Color.White;
            }
        }

        private void doc4b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc4b.Text, out parsedValue))
            {
                doc4b.BackColor = Color.Red;
            }
            else
            {
                doc4b.BackColor = Color.White;
            }
        }

        private void doc5b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc5b.Text, out parsedValue))
            {
                doc5b.BackColor = Color.Red;
            }
            else
            {
                doc5b.BackColor = Color.White;
            }
        }

        private void doc5a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(doc5a.Text, out parsedValue))
            {
                doc5a.BackColor = Color.Red;
            }
            else
            {
                doc5a.BackColor = Color.White;
            }
        }

        private void ov5b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov5b.Text, out parsedValue))
            {
                ov5b.BackColor = Color.Red;
            }
            else
            {
                ov5b.BackColor = Color.White;
            }
        }

        private void ov1a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov1a.Text, out parsedValue))
            {
                ov1a.BackColor = Color.Red;
            }
            else
            {
                ov1a.BackColor = Color.White;
            }
        }

        private void ov1b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov1b.Text, out parsedValue))
            {
                ov1b.BackColor = Color.Red;
            }
            else
            {
                ov1b.BackColor = Color.White;
            }
        }

        private void ov2a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov2a.Text, out parsedValue))
            {
                ov2a.BackColor = Color.Red;
            }
            else
            {
                ov2a.BackColor = Color.White;
            }
        }

        private void ov2b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov2b.Text, out parsedValue))
            {
                ov2b.BackColor = Color.Red;
            }
            else
            {
                ov2b.BackColor = Color.White;
            }
        }

        private void ov3a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov3a.Text, out parsedValue))
            {
                ov3a.BackColor = Color.Red;
            }
            else
            {
                ov3a.BackColor = Color.White;
            }
        }

        private void ov3b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov3b.Text, out parsedValue))
            {
                ov3b.BackColor = Color.Red;
            }
            else
            {
                ov3b.BackColor = Color.White;
            }
        }

        private void ov4a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov4a.Text, out parsedValue))
            {
                ov4a.BackColor = Color.Red;
            }
            else
            {
                ov4a.BackColor = Color.White;
            }
        }

        private void ov4b_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov4b.Text, out parsedValue))
            {
                ov4b.BackColor = Color.Red;
            }
            else
            {
                ov4b.BackColor = Color.White;
            }
        }

        private void ov5a_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(ov5a.Text, out parsedValue))
            {
                ov5a.BackColor = Color.Red;
            }
            else
            {
                ov5a.BackColor = Color.White;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.box1a.Text = "0";
            this.box1b.Text = "0";
            this.box2a.Text = "0";
            this.box2b.Text = "0";
            this.box3a.Text = "0";
            this.box3b.Text = "0";
            this.box4a.Text = "0";
            this.box4b.Text = "0";
            this.box5a.Text = "0";
            this.box5b.Text = "0";
            this.doc1a.Text = "0";
            this.doc1b.Text = "0";
            this.doc2a.Text = "0";
            this.doc2b.Text = "0";
            this.doc3a.Text = "0";
            this.doc3b.Text = "0";
            this.doc4a.Text = "0";
            this.doc4b.Text = "0";
            this.doc5a.Text = "0";
            this.doc5b.Text = "0";
            this.ov1a.Text = "0";
            this.ov1b.Text = "0";
            this.ov2a.Text = "0";
            this.ov2b.Text = "0";
            this.ov3a.Text = "0";
            this.ov3b.Text = "0";
            this.ov4a.Text = "0";
            this.ov4b.Text = "0";
            this.ov5a.Text = "0";
            this.ov5b.Text = "0";
            this.totalPages.Text = string.Empty;
            this.totalDocs.Text = string.Empty;
            this.overagebox.Text = string.Empty;

            this.box1a.SelectAll(); //highlights the first box
        }

        private void overagebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalDocs_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       