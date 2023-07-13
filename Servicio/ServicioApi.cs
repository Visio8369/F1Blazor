using F1Blazor2.Models;
using Newtonsoft.Json;

namespace F1Blazor2.Servicio
{
    public class ServicioApi : IServicioApi
    {
        private readonly HttpClient _cliente;

        public ServicioApi(HttpClient cliente)
        {
            _cliente = cliente;
        }

        public async Task<List<PilotoEnteroDTO>> GetPilotos()
        {

            List<PilotoEnteroDTO> pilotos = new List<PilotoEnteroDTO>();

            var response = await _cliente.GetAsync("api/Pilotos");

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                pilotos = JsonConvert.DeserializeObject<List<PilotoEnteroDTO>>(respuesta);
            }

            return pilotos;
        }

        public async Task<PilotoDTO> GetPiloto(int id)
        {
            PilotoDTO pilotoDto = new PilotoDTO();

            var response = await _cliente.GetAsync($"api/Pilotos/{id}");

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                pilotoDto = JsonConvert.DeserializeObject<PilotoDTO>(respuesta);
            }
            return pilotoDto;
        }

        public async Task<bool> CrearPiloto(CrearPilotoDTO modelo)
        {
            bool resultado = false;

            //var content = new StringContent(JsonConvert.SerializeObject(modelo), Encoding.UTF8, "application/json");

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(modelo.Nombre), "nombre");
            formData.Add(new StringContent(modelo.Apellido), "apellido");
            formData.Add(new StringContent(modelo.Nacionalidad), "nacionalidad");
            formData.Add(new StringContent(modelo.Edad.ToString()), "edad");
            formData.Add(new StreamContent(new MemoryStream(modelo.Foto)), "foto", "fileName");
            formData.Add(new StringContent(modelo.Poles.ToString()), "poles");
            formData.Add(new StringContent(modelo.Victorias.ToString()), "victorias");
            formData.Add(new StringContent(modelo.VueltasRapidas.ToString()), "vueltasrapidas");
            formData.Add(new StringContent(modelo.Puntos.ToString()), "puntos");
            formData.Add(new StringContent(modelo.IdEscuderia.ToString()), "idescuderia");
            formData.Add(new StringContent(modelo.Dorsal.ToString()), "dorsal");

            var response = await _cliente.PostAsync("api/Pilotos", formData);

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }
            return resultado;
        }

        public async Task<bool> ActualizarPiloto(int id, PilotoToUpdateDTO modelo)
        {
            bool resultado = false;

            //var content = new StringContent(JsonConvert.SerializeObject(modelo),Encoding.UTF8, "applicatio/json");

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(modelo.Edad.ToString()), "edad");
            formData.Add(new StreamContent(new MemoryStream(modelo.Foto)), "foto", "fileName");
            formData.Add(new StringContent(modelo.Poles.ToString()), "poles");
            formData.Add(new StringContent(modelo.Victorias.ToString()), "victorias");
            formData.Add(new StringContent(modelo.VueltasRapidas.ToString()), "vueltasrapidas");
            formData.Add(new StringContent(modelo.Puntos.ToString()), "puntos");
            formData.Add(new StringContent(modelo.IdEscuderia.ToString()), "idescuderia");
            formData.Add(new StringContent(modelo.Dorsal.ToString()), "dorsal");

            var response = await _cliente.PutAsync($"api/Pilotos/{id}", formData);

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        public async Task<bool> EliminarPiloto(int id)
        {
            bool resultado = false;

            var result = await _cliente.DeleteAsync($"api/Pilotos/{id}");

            if (result.IsSuccessStatusCode)
            {
                resultado = true;
            }
            return resultado;
        }

        //Escuderias
        public async Task<List<EscuderiumEnteroDTO>> GetEscuderias()
        {

            List<EscuderiumEnteroDTO> escuderias = new List<EscuderiumEnteroDTO>();

            var response = await _cliente.GetAsync("api/Escuderias");

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                escuderias = JsonConvert.DeserializeObject<List<EscuderiumEnteroDTO>>(respuesta);
            }

            return escuderias;
        }

        public async Task<EscuderiumDTO> GetEscuderia(int id)
        {

            EscuderiumDTO escuderia = new EscuderiumDTO();

            var response = await _cliente.GetAsync($"api/Escuderias/{id}");

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                escuderia = JsonConvert.DeserializeObject<EscuderiumDTO>(respuesta);
            }

            return escuderia;
        }

        public async Task<bool> CrearEscuderia(CrearEscuderiumDTO modelo)
        {

            bool resultado = false;

            //var content = new StringContent(JsonConvert.SerializeObject(modelo), Encoding.UTF8, "application/json");

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(modelo.Nombre), "nombre");
            formData.Add(new StringContent(modelo.TeamPrincipal), "teamprincipal");
            formData.Add(new StringContent(modelo.Nacionalidad), "nacionalidad");
            formData.Add(new StreamContent(new MemoryStream(modelo.Escudo)), "escudo", "fileName");
            formData.Add(new StringContent(modelo.Victorias.ToString()), "victorias");
            formData.Add(new StringContent(modelo.Poles.ToString()), "poles");
            formData.Add(new StringContent(modelo.Puntos.ToString()), "puntos");
            formData.Add(new StringContent(modelo.VueltasRapidas.ToString()), "vueltasrapidas");

            var response = await _cliente.PostAsync("api/Escuderias", formData);

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        public async Task<bool> ActualizarEscuderia(int id, EscuderiumDTOUpdate modelo)
        {

            bool resultado = false;

            //var content = new StringContent(JsonConvert.SerializeObject(modelo), Encoding.UTF8, "application/json");

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(modelo.Nombre), "nombre");
            formData.Add(new StringContent(modelo.TeamPrincipal), "teamprincipal");
            formData.Add(new StreamContent(new MemoryStream(modelo.Escudo)), "escudo", "fileName");
            formData.Add(new StringContent(modelo.Victorias.ToString()), "victorias");
            formData.Add(new StringContent(modelo.Poles.ToString()), "poles");
            formData.Add(new StringContent(modelo.Puntos.ToString()), "puntos");
            formData.Add(new StringContent(modelo.VueltasRapidas.ToString()), "vueltasrapidas");

            var response = await _cliente.PutAsync($"api/Escuderias/{id}", formData);

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        public async Task<bool> EliminarEscuderia(int id)
        {

            bool resultado = false;

            var response = await _cliente.DeleteAsync($"api/Escuderias/{id}");

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        //Carreras

        public async Task<List<CarreraEnteraDTO>> GetCarreras()
        {

            List<CarreraEnteraDTO> carreras = new List<CarreraEnteraDTO>();

            var response = await _cliente.GetAsync("api/Carreras");

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                carreras = JsonConvert.DeserializeObject<List<CarreraEnteraDTO>>(respuesta);
            }
            return carreras;
        }

        public async Task<CarreraDTO> GetCarrera(int id)
        {

            CarreraDTO carrera = new CarreraDTO();

            var response = await _cliente.GetAsync($"api/Carreras/{id}");

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await response.Content.ReadAsStringAsync();
                carrera = JsonConvert.DeserializeObject<CarreraDTO>(respuesta);
            }
            return carrera;
        }

        public async Task<bool> CrearCarrera(CrearCarreraDTO modelo)
        {

            bool resultado = false;

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(modelo.Nombre), "nombre");
            formData.Add(new StringContent(modelo.Pais), "pais");
            formData.Add(new StringContent(modelo.Fecha.ToString()), "fecha");
            formData.Add(new StreamContent(new MemoryStream(modelo.Bandera)), "bandera", "fileName");


            var response = await _cliente.PostAsync("api/Carreras", formData);

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        public async Task<bool> ActualizarCarrera(int id, CarreraDTOUpdate modelo)
        {

            bool resultado = false;

            var formData = new MultipartFormDataContent();
            formData.Add(new StringContent(modelo.Nombre), "nombre");
            formData.Add(new StringContent(modelo.Fecha.ToString()), "fecha");

            var response = await _cliente.PutAsync($"api/Carreras/{id}", formData);
            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        public async Task<bool> EliminarCarrera(int id)
        {

            bool resultado = false;

            var response = await _cliente.DeleteAsync($"api/Carreras/{id}");

            if (response.IsSuccessStatusCode)
            {
                resultado = true;
            }

            return resultado;
        }

        public async Task<List<Clasificacion>> GetClasificacion()
        {
            try
            {
                List<Clasificacion> clasificacion = new List<Clasificacion>();

                var response = await _cliente.GetAsync("api/Resultados");

                if (response.IsSuccessStatusCode)
                {
                    var respuesta = await response.Content.ReadAsStringAsync();
                    clasificacion = JsonConvert.DeserializeObject<List<Clasificacion>>(respuesta);
                }
                return clasificacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
