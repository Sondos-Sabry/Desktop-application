using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2
{
    
    public partial class Form1 : Form
    {
        EF1Context db;
        public Form1()
        {
            InitializeComponent();

            db = new EF1Context();

            
           
            dgv_student.DataSource = db.students.Include(n => n.department).Select(n => new { n.id, n.name, n.address, n.age, Department = n.department.dept }).ToList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            // load data in comboBox
            cb_dept.DataSource = db.departments.ToList();
            cb_dept.DisplayMember = "dept";
            cb_dept.ValueMember = "id";


            //load student's data in grid

            dgv_student.DataSource = db.students.Where(n => n.name.Contains(txt_search.Text)).ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            student s = new student()
            {
                id = int.Parse(txt_id.Text),
                name = txt_name.Text,
                address = txt_address.Text,
                age = int.Parse(txt_age.Text),
                dept_id = (int)cb_dept.SelectedValue
            };

            btn_delete.Visible = false;
            btn_update.Visible = false;

            db.students.Add(s);
            db.SaveChanges();
            label6.Text = "Done";
            txt_id.Text = txt_name.Text = txt_address.Text = txt_age.Text = " ";
            dgv_student.DataSource = db.students.Include(n => n.department).Select(n => new { n.id, n.name, n.address, n.age, Department = n.department.dept }).ToList();
        }

        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
 
            int Id = (int)dgv_student.SelectedRows[0].Cells[0].Value;
            student s = db.students.Where(n => n.id == Id).SingleOrDefault();
            txt_id.Text =s.id.ToString();
            txt_name.Text = s.name;
            txt_address.Text=s.address;
            txt_age.Text=s.age.ToString();
            cb_dept.SelectedValue = s.dept_id;
            btn_delete.Visible = true;
            btn_update.Visible =true;
            btn_add.Visible = false;
            txt_id.Enabled = false;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);

            student s = db.students.Where(n => n.id == id).SingleOrDefault();
            s.name = txt_name.Text;
            s.address = txt_address.Text;
            s.age =int.Parse(txt_age.Text);
            s.dept_id = (int)cb_dept.SelectedValue; 

            db.SaveChanges();
            label6.Text = "Updated";
            txt_id.Text = txt_name.Text = txt_address.Text = txt_age.Text = "";
           
            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_add.Visible = true;
            txt_id.Enabled = true;

            dgv_student.DataSource = db.students.Where(n => n.name.Contains(txt_search.Text)).ToList();



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure to delete thid row ?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int id = int.Parse(txt_id.Text);
                student s = db.students.Where(n => n.id == id).SingleOrDefault();
                db.students.Remove(s);
                db.SaveChanges();
                label6.Text = "Deleted";
                txt_id.Text = txt_name.Text = txt_address.Text = txt_age.Text = "";
                btn_delete.Visible = false;
                btn_update.Visible = false;
                btn_add.Visible = true;
                txt_id.Enabled = true;

            dgv_student.DataSource = db.students.Where(n => n.name.Contains(txt_search.Text)).ToList();




            }
        }
    }
}