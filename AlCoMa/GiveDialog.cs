using AlCoMa.types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlCoMa
{
    public partial class GiveDialog : Form
    {
        private List<Friend> items;

        public Friend? SelectedFriend { get; internal set; }

        public GiveDialog()
        {
            InitializeComponent();
        }

        public void SetFriends(IEnumerable<Friend> friends)
        {
            FriendsListBox.Items.Clear();
            this.items = friends.ToList();
            foreach (Friend friend in this.items)
            {
                FriendsListBox.Items.Add(friend.Name);
            }
        }

        public void SetCards(String text) 
        {
            this.CardsToGIveTextBox.Text = text;    
        }

        private void FriendFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = FriendFilterTextBox.Text.ToLower();
            FriendsListBox.Items.Clear();
            var filteredItems = items.Where(item => item.Name.ToLower().Contains(filter)).ToArray();
            foreach (Friend friend in filteredItems)
            {
                FriendsListBox.Items.Add(friend.Name);
            }
        }

        private void FriendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiveButton.Enabled = FriendsListBox.SelectedIndex != -1;
            SelectedFriend = items.SingleOrDefault(x => x.Name == FriendsListBox.SelectedItem?.ToString());
        }
    }
}
