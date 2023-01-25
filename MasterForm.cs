using System.Windows.Forms;

namespace SchoolProject
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void linkCourses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TopicForm topicForm = new TopicForm();
            topicForm.TopLevel = false;
            topicForm.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(topicForm);
            topicForm.Show();
        }
    }
}