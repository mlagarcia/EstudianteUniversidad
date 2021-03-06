using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteUniversidad.Controller
{
    public class Validator
    {
        public void InitCbo(System.Windows.Forms.ComboBox Cbo)
        {
            Cbo.DropDownHeight = Cbo.Font.Height * 5;
            Cbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            Cbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }


        public void nInitCbo(System.Windows.Forms.ComboBox Cbo)
        {
            Cbo.DropDownHeight = Cbo.Font.Height * 5;
            Cbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            Cbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        }

        public List<string> ListaTipoBusquedaIns()
        {
            List<string> busqueda = new List<string>();
            busqueda.Add("Buscar por nombre");
            busqueda.Add("Buscar por apellido");
            busqueda.Add("Buscar por universidad");
            return busqueda;
        }
            public List<string> ListadoPaises()
        {
            List<string> paises = new List<string>();
            paises.Add("Afganistán");
            paises.Add("Akrotiri");
            paises.Add("Albania");
            paises.Add("Alemania");
            paises.Add("Andorra");
            paises.Add("Angola");
            paises.Add("Anguila");
            paises.Add("Antártida");
            paises.Add("Antigua y Barbuda");
            paises.Add("Arabia Saudí");
            paises.Add("Arctic Ocean");
            paises.Add("Argelia");
            paises.Add("Argentina");
            paises.Add("Armenia");
            paises.Add("Aruba");
            paises.Add("Ashmore and Cartier Islands");
            paises.Add("Atlantic Ocean");
            paises.Add("Australia");
            paises.Add("Austria");
            paises.Add("Azerbaiyán");
            paises.Add("Bahamas");
            paises.Add("Bahráin");
            paises.Add("Bangladesh");
            paises.Add("Barbados");
            paises.Add("Bélgica");
            paises.Add("Belice");
            paises.Add("Benín");
            paises.Add("Bermudas");
            paises.Add("Bielorrusia");
            paises.Add("Birmania; Myanmar");
            paises.Add("Bolivia");
            paises.Add("Bosnia y Hercegovina");
            paises.Add("Botsuana");
            paises.Add("Brasil");
            paises.Add("Brunéi");
            paises.Add("Bulgaria");
            paises.Add("Burkina Faso");
            paises.Add("Burundi");
            paises.Add("Bután");
            paises.Add("Cabo Verde");
            paises.Add("Camboya");
            paises.Add("Camerún");
            paises.Add("Canadá");
            paises.Add("Chad");
            paises.Add("Chile");
            paises.Add("China");
            paises.Add("Chipre");
            paises.Add("Clipperton Island");
            paises.Add("Colombia");
            paises.Add("Comoras");
            paises.Add("Congo");
            paises.Add("Coral Sea Islands");
            paises.Add("Corea del Norte");
            paises.Add("Corea del Sur");
            paises.Add("Costa de Marfil"); 
            paises.Add("Costa Rica");
            paises.Add("Croacia");
            paises.Add("Cuba");
            paises.Add("Curacao");
            paises.Add("Dhekelia");
            paises.Add("Dinamarca");
            paises.Add("Dominica");
            paises.Add("Ecuador");
            paises.Add("Egipto");
            paises.Add("El Salvador");
            paises.Add("El Vaticano");
            paises.Add("Emiratos Árabes Unidos");
            paises.Add("Eritrea");
            paises.Add("Eslovaquia");
            paises.Add("Eslovenia");
            paises.Add("España");
            paises.Add("Estados Unidos");
            paises.Add("Estonia");
            paises.Add("Etiopía");
            paises.Add("Filipinas");
            paises.Add("Finlandia");
            paises.Add("Fiyi");
            paises.Add("Francia");
            paises.Add("Gabón");
            paises.Add("Gambia");
            paises.Add("Gaza Strip");
            paises.Add("Georgia");
            paises.Add("Ghana");
            paises.Add("Gibraltar");
            paises.Add("Granada");
            paises.Add("Grecia");
            paises.Add("Groenlandia");
            paises.Add("Guam");
            paises.Add("Guatemala");
            paises.Add("Guernsey");
            paises.Add("Guinea");
            paises.Add("Guinea Ecuatorial");
            paises.Add("Guinea-Bissau");
            paises.Add("Guyana");
            paises.Add("Haití");
            paises.Add("Honduras");
            paises.Add("Hong Kong");
            paises.Add("Hungría");
            paises.Add("India");
            paises.Add("Indian Ocean");
            paises.Add("Indonesia");
            paises.Add("Irán");
            paises.Add("Iraq");
            paises.Add("Irlanda");
            paises.Add("Isla Bouvet");
            paises.Add("Isla Christmas");
            paises.Add("Isla Norfolk");
            paises.Add("Islandia");
            paises.Add("Islas Caimán");
            paises.Add("Islas Cocos");
            paises.Add("Islas Cook");
            paises.Add("Islas Feroe");
            paises.Add("Islas Georgia del Sur y Sandwich del Sur");
            paises.Add("Islas Heard y McDonald");
            paises.Add("Islas Malvinas");
            paises.Add("Islas Marianas del Norte");
            paises.Add("Islas Marshall");
            paises.Add("Islas Pitcairn");
            paises.Add("Islas Salomón");
            paises.Add("Islas Turcas y Caicos");
            paises.Add("Islas Vírgenes Americanas");
            paises.Add("Islas Vírgenes Británicas");
            paises.Add("Israel");
            paises.Add("Italia");
            paises.Add("Jamaica");
            paises.Add("Jan Mayen");
            paises.Add("Japón");
            paises.Add("Jersey");
            paises.Add("Jordania");
            paises.Add("Kazajistán");
            paises.Add("Kenia");
            paises.Add("Kirguizistán");
            paises.Add("Kiribati");
            paises.Add("Kosovo");
            paises.Add("Kuwait");
            paises.Add("Laos");
            paises.Add("Lesoto");
            paises.Add("Letonia");
            paises.Add("Líbano");
            paises.Add("Liberia");
            paises.Add("Libia");
            paises.Add("Liechtenstein");
            paises.Add("Lituania");
            paises.Add("Luxemburgo");
            paises.Add("Macao");
            paises.Add("Macedonia");
            paises.Add("Madagascar");
            paises.Add("Malasia");
            paises.Add("Malaui");
            paises.Add("Maldivas");
            paises.Add("Malí");
            paises.Add("Malta");
            paises.Add("Man, Isle of");
            paises.Add("Marruecos");
            paises.Add("Mauricio");
            paises.Add("Mauritania");
            paises.Add("México");
            paises.Add("Micronesia");
            paises.Add("Moldavia");
            paises.Add("Mónaco");
            paises.Add("Mongolia");
            paises.Add("Montenegro");
            paises.Add("Montserrat");
            paises.Add("Mozambique");
            paises.Add("Namibia");
            paises.Add("Nauru");
            paises.Add("Navassa Island");
            paises.Add("Nepal");
            paises.Add("Nicaragua");
            paises.Add("Níger");
            paises.Add("Nigeria");
            paises.Add("Niue");
            paises.Add("Noruega");
            paises.Add("Nueva Caledonia");
            paises.Add("Nueva Zelanda");
            paises.Add("Omán");
            paises.Add("Países Bajos");
            paises.Add("Pakistán");
            paises.Add("Palaos");
            paises.Add("Panamá");
            paises.Add("Papúa-Nueva Guinea");
            paises.Add("Paracel Islands");
            paises.Add("Paraguay");
            paises.Add("Perú");
            paises.Add("Polonia");
            paises.Add("Portugal");
            paises.Add("Puerto Rico");
            paises.Add("Qatar");
            paises.Add("Reino Unido");
            paises.Add("República Centroafricana");
            paises.Add("República Democrática del Congo");
            paises.Add("República Dominicana");
            paises.Add("Ruanda");
            paises.Add("Rumania");
            paises.Add("Rusia");
            paises.Add("Sáhara Occidental");
            paises.Add("Samoa");
            paises.Add("Samoa Americana");
            paises.Add("San Bartolomé");
            paises.Add("San Cristóbal y Nieves");
            paises.Add("San Marino");
            paises.Add("San Martín");
            paises.Add("San Pedro y Miquelón");
            paises.Add("San Vicente y las Granadinas");
            paises.Add("Santa Helena");
            paises.Add("Santa Lucía");
            paises.Add("Santo Tomé y Príncipe");
            paises.Add("Senegal");
            paises.Add("Serbia");
            paises.Add("Seychelles");
            paises.Add("Sierra Leona");
            paises.Add("Singapur");
            paises.Add("Sint Maarten");
            paises.Add("Siria");
            paises.Add("Somalia");
            paises.Add("Spratly Islands");
            paises.Add("Sri Lanka");
            paises.Add("Suazilandia");
            paises.Add("Sudáfrica");
            paises.Add("Sudán");
            paises.Add("Sudán del Sur");
            paises.Add("Suecia");
            paises.Add("Suiza");
            paises.Add("Surinam");
            paises.Add("Svalbard y Jan Mayen");
            paises.Add("Tailandia");
            paises.Add("Taiwán");
            paises.Add("Tanzania");
            paises.Add("Tayikistán");
            paises.Add("Territorio Británico del Océano Indico");
            paises.Add("Territorios Australes Franceses");
            paises.Add("Timor Oriental");
            paises.Add("Togo");
            paises.Add("Tokelau");
            paises.Add("Tonga");
            paises.Add("Trinidad y Tobago");
            paises.Add("Túnez");
            paises.Add("Turkmenistán");
            paises.Add("Turquía");
            paises.Add("Tuvalu");
            paises.Add("Ucrania");
            paises.Add("Uganda");            
            paises.Add("Uruguay");
            paises.Add("Uzbekistán");
            paises.Add("Vanuatu");
            paises.Add("Venezuela");
            paises.Add("Vietnam");
            paises.Add("Wake Island");
            paises.Add("Wallis y Futuna");
            paises.Add("West Bank");
            paises.Add("Yemen");
            paises.Add("Yibuti");
            paises.Add("Zambia");
            paises.Add("Zimbabue");
            return paises;
        }


    }
}
