using System.Collections.Generic;
using System.Windows.Forms;
using Service.ServiceClient;
using Service.ServiceClient.DTOs;
using Service.ServiceMovie;
using Service.ServiceMovie.DTOs;

namespace Main.FormSecondary
{
    public partial class FormHome : Form
    {
        private MovieService movieService;
        private ClientService clientService;
        private List<MovieDto> movieDtos = new List<MovieDto>();
        private List<ClientDto> clientDtos = new List<ClientDto>(); 
        public FormHome()
        {
            InitializeComponent();
            movieService = new MovieService();
            clientService = new ClientService();

            
            movieDtos=movieService.getMovies();
            clientDtos=clientService.getClients();

            fillData();
        }

        private void fillData()
        {
            foreach (var item in clientDtos)
            {
                int nclient = dgvClients.Rows.Add();
                dgvClients.Rows[nclient].Cells[0].Value = item.Id;
                dgvClients.Rows[nclient].Cells[1].Value = item.Name;
                dgvClients.Rows[nclient].Cells[2].Value = item.LastName;
                
            }

            foreach (var item in movieDtos)
            {
                int nmovie = dgvStockMovies.Rows.Add();
                dgvStockMovies.Rows[nmovie].Cells[0].Value = item.Id;
                dgvStockMovies.Rows[nmovie].Cells[1].Value = item.Name;
                dgvStockMovies.Rows[nmovie].Cells[2].Value = item.Gender;
                dgvStockMovies.Rows[nmovie].Cells[3].Value = item.Amount;
            }
            
        }
    }
}
