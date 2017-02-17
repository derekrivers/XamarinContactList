using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace WebRequestTutorial
{
    class ContactListAdapter : BaseAdapter<Contact>
    {
        private Context mContext;
        private int mLayout;
        private List<Contact> mContacts;
        private Action<ImageView> mActionPicSelected;

        public ContactListAdapter (Context context, int layout, List<Contact> contacts, Action<ImageView> picSelected)
        {
            mContext = context;
            mLayout = layout;
            mContacts = contacts;
            mActionPicSelected = picSelected;
        }

        public override Contact this[int position]
        {
            get { return mContacts[position]; }
        }

        public override int Count
        {
            get { return mContacts.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(mLayout, parent, false);
            }

            row.FindViewById<TextView>(Resource.Id.txtName).Text = mContacts[position].Name;
            row.FindViewById<TextView>(Resource.Id.txtNumber).Text = mContacts[position].Number;

            ImageView pic = row.FindViewById<ImageView>(Resource.Id.imgPic);

            pic.Click -= Pic_Click;
            pic.Click += Pic_Click;

            if (mContacts[position].Image != null)
            {
                pic.SetImageBitmap(BitmapFactory.DecodeByteArray(mContacts[position].Image, 0, mContacts[position].Image.Length));
            }

            return row;
        }

        void Pic_Click(object sender, EventArgs e)
        {
            //Picture has been clicked 
            mActionPicSelected.Invoke((ImageView)sender);
        }
    }
}