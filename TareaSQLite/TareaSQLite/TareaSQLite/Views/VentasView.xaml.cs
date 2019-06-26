using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaSQLite.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaSQLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentasView : ContentPage
    {
        public VentasView()
        {
            InitializeComponent();
        }

        private void BInsertar_Click(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            VentasViewModel.Instance.AddNewNote(dContents.Text);
            StatusMessage.Text = VentasViewModel.Instance.EstadoMensaje;
        }

        private void BListar_Clicked(object sender, EventArgs e)
        {
            var allNotes = VentasViewModel.Instance.GetAllNotes();
            listanotas.ItemsSource = allNotes;
            StatusMessage.Text = VentasViewModel.Instance.EstadoMensaje;
        }

    }
}