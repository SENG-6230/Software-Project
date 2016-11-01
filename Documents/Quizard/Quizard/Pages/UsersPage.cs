﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizard.Pages
{
    public partial class UsersPage : UserControl, QuizardPage
    {
        User currentUser = null;

        public UsersPage()
        {
            InitializeComponent();
        }

        public void ShowPage(User user)
        {
            populateUserList();
            clearSelection();
        }

        private void populateUserList()
        {
            usersBx.Nodes.Clear();
            List<User> users = Program.Database.GetAllUsers();
            foreach (User user in users)
            {
                TreeNode newNode = new TreeNode(user.Name);
                newNode.Tag = user;
                usersBx.Nodes.Add(newNode);
            }
        }

        private void clearSelection()
        {
            currentUser = null;
            nameBx.Text = "";
            emailBx.Text = "";
            passwordBx.Text = "";
            roleCbx.SelectedIndex = -1;
            createBtn.Visible = false;
        }

        private void populateUserInfo(User newUser)
        {
            currentUser = newUser;
            nameBx.Text = newUser.Name;
            emailBx.Text = newUser.Email;
            passwordBx.Text = newUser.Password;
            roleCbx.SelectedIndex = (int)newUser.Role -1;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Program.Database.CreateUser(
                    Name: nameBx.Text,
                    email: emailBx.Text,
                    password: passwordBx.Text,
                    role: roleCbx.Text);
            clearSelection();
            populateUserList();
        }

        private void usersBx_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            populateUserInfo((User)e.Node.Tag);
            createBtn.Visible = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateUserInfo((User)usersBx.SelectedNode.Tag);
            createBtn.Visible = true;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            clearSelection();
            createBtn.Visible = true;
        }
    }
}
