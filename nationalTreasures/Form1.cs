namespace nationalTreasures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboContinent.Items.Add("Africa");
            cboContinent.Items.Add("Antarctica");
            cboContinent.Items.Add("Asia");
            cboContinent.Items.Add("Europe");
            cboContinent.Items.Add("North America");
            cboContinent.Items.Add("South America");
            cboContinent.Items.Add("Oceania or Australia");

            cboPaymentType.Items.Add("Visa");
            cboPaymentType.Items.Add("Master Card");
            cboPaymentType.Items.Add("PayPal");
        }

        private void cboContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboContinent.SelectedItem.Equals("Asia"))

            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Japan");
                cboCountry.Items.Add("Vietnam");
                cboCountry.Items.Add("Thailand");
                cboCountry.Items.Add("India");
                cboCountry.Items.Add("China");

            }
            if (cboContinent.SelectedItem.Equals("Africa"))

            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("South Africa");
                cboCountry.Items.Add("Congo");
                cboCountry.Items.Add("Egypt");
                cboCountry.Items.Add("Kenya");
                cboCountry.Items.Add("Madagascar");

            }
            if (cboContinent.SelectedItem.Equals("Antarctica"))
            {
                string message = "There are no countries in Antarctica, but seven nations claim part of it. Here are five of them.";
                MessageBox.Show(message);
                cboCountry.Items.Clear();
                cboCountry.Items.Add("New Zealand");
                cboCountry.Items.Add("Australia");
                cboCountry.Items.Add("France");
                cboCountry.Items.Add("Norway");
                cboCountry.Items.Add("United Kingdom");
            }
            if (cboContinent.SelectedItem.Equals("Europe"))

            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Germany");
                cboCountry.Items.Add("Russia");
                cboCountry.Items.Add("Italy");
                cboCountry.Items.Add("Greece");
                cboCountry.Items.Add("Sweden");

            }
            if (cboContinent.SelectedItem.Equals("North America"))

            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Canada");
                cboCountry.Items.Add("Mexico");
                cboCountry.Items.Add("United States");
                cboCountry.Items.Add("Cuba");
                cboCountry.Items.Add("Greenland");

            }
            if (cboContinent.SelectedItem.Equals("South America"))

            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Brazil");
                cboCountry.Items.Add("Argentina");
                cboCountry.Items.Add("Columbia");
                cboCountry.Items.Add("Peru");
                cboCountry.Items.Add("Chile");

            }
            if (cboContinent.SelectedItem.Equals("Oceania or Australia"))

            {
                cboCountry.Items.Clear();
                cboCountry.Items.Add("Australia");
                cboCountry.Items.Add("Palau");
                cboCountry.Items.Add("Solomon Islands");
                cboCountry.Items.Add("Marshall Islands");
                cboCountry.Items.Add("Fiji");
            }
    }

    private void btnPurchase_MouseClick(object sender, EventArgs e)
        {
            //The "\n" is a line break.  
            //Notice how I calculate the total, then I have to format it as currency.  Two different variables.
            string myCountry = cboCountry.Text;
            string myContinent = cboContinent.Text;
            string myAttraction = cboAttraction.Text;
            long myNumberOfPeople = Convert.ToInt64(txtNumberOfPeople.Text);
            string myPaymentType = cboPaymentType.Text;
            double myTotalAmount = myNumberOfPeople * 500;
            string myFormattedTotalAmount = myTotalAmount.ToString("c");
            string myMessage = "Hello User!  You are going to " + myAttraction + " in the country of " + myCountry
                + " on the continent of " + myContinent + "." + "\n" + "There will be " + myNumberOfPeople + " people traveling, so " +
                "that will be a total of " + myFormattedTotalAmount + " paid by " + myPaymentType + "." + "\n" + "Thank you for traveling with us.";
            MessageBox.Show(myMessage);
            txtAnswer.Text = myMessage;

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asia
            if (cboCountry.SelectedItem.Equals("Japan"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Himeji Castle");
                cboAttraction.Items.Add("Itsukushima Shrine");
                cboAttraction.Items.Add("Nara Park");
                cboAttraction.Items.Add("Mount Fuji");
                cboAttraction.Items.Add("Shinjuku Gyoen National Garden");
            }
            if (cboCountry.SelectedItem.Equals("Vietnam"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Halong Bay");
                cboAttraction.Items.Add("Ho Chi Minh City");
                cboAttraction.Items.Add("Hue");
                cboAttraction.Items.Add("Phong Nha-Ke Bang National Park");
                cboAttraction.Items.Add("Hoi An");
            }
            if (cboCountry.SelectedItem.Equals("Thailand"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Railay Beach");
                cboAttraction.Items.Add("Koh Phi Phi");
                cboAttraction.Items.Add("The Grand Palace, Bangkok");
                cboAttraction.Items.Add("Sunday Walking Street, Chiang Mai");
                cboAttraction.Items.Add("Khao Yai National Park");
            }
            if (cboCountry.SelectedItem.Equals("India"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("The Taj Mahal, Agra");
                cboAttraction.Items.Add("The Holy City of Varanasi");
                cboAttraction.Items.Add("The Red Fort, New Delhi");
                cboAttraction.Items.Add("The Beaches of Goa");
                cboAttraction.Items.Add("Periyar National Park and Wildlife Sanctuary, Madurai");
            }
            if (cboCountry.SelectedItem.Equals("China"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("The Great Wall of China");
                cboAttraction.Items.Add("The Forbidden City & Imperial Palace, Beijing");
                cboAttraction.Items.Add("The Terracotta Army, Xi'an");
                cboAttraction.Items.Add("Chengdu Research Base of Giant Panda Breeding, Sichuan");
                cboAttraction.Items.Add("The Yangtze River and the Three Gorges");
            }
            //africa
            if (cboCountry.SelectedItem.Equals("South Africa"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Kruger National Park");
                cboAttraction.Items.Add("Cape Town, Western Cape");
                cboAttraction.Items.Add("The Garden Route National Park");
                cboAttraction.Items.Add("The Drakensberg, KwaZulu-Natal");
                cboAttraction.Items.Add("Cage Diving with Great White Sharks");
            }
            if (cboCountry.SelectedItem.Equals("Congo"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Kinshasa");
                cboAttraction.Items.Add("Lola Ya Bonobo");
                cboAttraction.Items.Add("Kahuzi Biega National Park");
                cboAttraction.Items.Add("Nyiragongo Volcano");
                cboAttraction.Items.Add("Lake Kivu");
            }
            if (cboCountry.SelectedItem.Equals("Egypt"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Pyramids of Giza");
                cboAttraction.Items.Add("Luxor's Karnak Temple and the Valley of the Kings");
                cboAttraction.Items.Add("Abu Simbel");
                cboAttraction.Items.Add("Diving in the Red Sea");
                cboAttraction.Items.Add("White Desert National Park");
            }
            if (cboCountry.SelectedItem.Equals("Kenya"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Maasai Mara National Park");
                cboAttraction.Items.Add("Amboseli National Reserve");
                cboAttraction.Items.Add("Lake Nakuru National Park");
                cboAttraction.Items.Add("Nairobi");
                cboAttraction.Items.Add("Malindi");
            }
            if (cboCountry.SelectedItem.Equals("Madagascar"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Masoala National Park");
                cboAttraction.Items.Add("Andasibe-Mantadia National Park");
                cboAttraction.Items.Add("Royal Hill of Ambohimanga");
                cboAttraction.Items.Add("Avenue of the Baobabs");
                cboAttraction.Items.Add("Ile Sainte Marie");
            }
            //antarctica
            if (cboCountry.SelectedItem.Equals("New Zealand"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Fiordland National Park and Milford Sound, South Island");
                cboAttraction.Items.Add("Bay of Islands, North Island");
                cboAttraction.Items.Add("Queenstown, South Island");
                cboAttraction.Items.Add("Lake Taupo and Tongariro National Park, North Island");
                cboAttraction.Items.Add("Rotorua, North Island");
            }
            if (cboCountry.SelectedItem.Equals("Australia"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Sydney Opera House");
                cboAttraction.Items.Add("Great Barrier Reef Marine Park");
                cboAttraction.Items.Add("Uluru-Kata Tjuta National Park");
                cboAttraction.Items.Add("Sydney Harbour Bridge");
                cboAttraction.Items.Add("Blue Mountains National Park");
            }
            if (cboCountry.SelectedItem.Equals("France"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Eiffel Tower");
                cboAttraction.Items.Add("Musée du Louvre");
                cboAttraction.Items.Add("Château de Versailles");
                cboAttraction.Items.Add("Côte d'Azur");
                cboAttraction.Items.Add("Mont Saint-Michel");
            }
            if (cboCountry.SelectedItem.Equals("Norway"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Sognefjord");
                cboAttraction.Items.Add("Pulpit Rock");
                cboAttraction.Items.Add("Tromsø");
                cboAttraction.Items.Add("Lofoten Islands");
                cboAttraction.Items.Add("Bygdoy Peninsula");
            }
            if (cboCountry.SelectedItem.Equals("United Kingdom"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Stonehenge");
                cboAttraction.Items.Add("Tower of London");
                cboAttraction.Items.Add("Windsor Castle");
                cboAttraction.Items.Add("Cardiff Castle & National Museum");
                cboAttraction.Items.Add("Loch Ness and the Caledonian Canal");
            }
            //europe
            if (cboCountry.SelectedItem.Equals("Germany"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Berlin's Brandenburg Gate");
                cboAttraction.Items.Add("Cologne Cathedral (Kölner Dom)");
                cboAttraction.Items.Add("The Black Forest");
                cboAttraction.Items.Add("Miniatur Wunderland and the Historic Port of Hamburg");
                cboAttraction.Items.Add("Insel Mainau: The Flower Island of Lake Constance");
            }
            if (cboCountry.SelectedItem.Equals("Italy"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Colosseum");
                cboAttraction.Items.Add("The Grand Canal in Venice");
                cboAttraction.Items.Add("Pompeii and Mount Vesuvius");
                cboAttraction.Items.Add("Leaning Tower of Pisa");
                cboAttraction.Items.Add("Vatican City: Basilica of St. Peter, Sistine Chapel & Vatican Museums");
            }
            if (cboCountry.SelectedItem.Equals("Russia"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Trans-Siberian Railway");
                cboAttraction.Items.Add("Mount Elbrus");
                cboAttraction.Items.Add("Valley of Geysers");
                cboAttraction.Items.Add("St Sophia Cathedral, Novgorod");
                cboAttraction.Items.Add("Moscow Kremlin");
            }
            if (cboCountry.SelectedItem.Equals("Greece"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Acropolis & Museum, Athens");
                cboAttraction.Items.Add("Santorini");
                cboAttraction.Items.Add("Delphi");
                cboAttraction.Items.Add("The Towns and Beaches of Crete");
                cboAttraction.Items.Add("Metéora Monasteries");
            }
            if (cboCountry.SelectedItem.Equals("Sweden"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Vasa Museum, Stockholm");
                cboAttraction.Items.Add("Drottningholm Palace, Lovö");
                cboAttraction.Items.Add("Kiruna and the Ice Hotel, Lapland");
                cboAttraction.Items.Add("Visby, Gotland");
                cboAttraction.Items.Add("Liseberg Theme Park, Gothenburg");
            }
            //north america
            if (cboCountry.SelectedItem.Equals("Canada"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Niagara Falls");
                cboAttraction.Items.Add("Banff National Park & the Rocky Mountains");
                cboAttraction.Items.Add("Old Quebec (Vieux-Quebec)");
                cboAttraction.Items.Add("Whistler");
                cboAttraction.Items.Add("Polar Bears of Churchill, Manitoba");
            }
            if (cboCountry.SelectedItem.Equals("Mexico"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Puebla");
                cboAttraction.Items.Add("Acapulco");
                cboAttraction.Items.Add("Playa del Carmen");
                cboAttraction.Items.Add("Los Cabos");
                cboAttraction.Items.Add("Cancun");
            }
            if (cboCountry.SelectedItem.Equals("United States"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Yellowstone National Park");
                cboAttraction.Items.Add("New York City");
                cboAttraction.Items.Add("Mount Rushmore");
                cboAttraction.Items.Add("Las Vegas");
                cboAttraction.Items.Add("Navy Pier");
            }
            if (cboCountry.SelectedItem.Equals("Cuba"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Old Havana (Habana Vieja)");
                cboAttraction.Items.Add("Varadero");
                cboAttraction.Items.Add("Trinidad");
                cboAttraction.Items.Add("Cayo Coco");
                cboAttraction.Items.Add("Peninsula de Zapata (Ciénaga de Zapata)");
            }
            if (cboCountry.SelectedItem.Equals("Greenland"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Ilulissat Ice-fjord");
                cboAttraction.Items.Add("Whale Watching");
                cboAttraction.Items.Add("Nuuk and the Greenland National Museum");
                cboAttraction.Items.Add("The Northern Lights (Aurora Borealis)");
                cboAttraction.Items.Add("Uunartoq Hot Springs");
            }
            //south america
            if (cboCountry.SelectedItem.Equals("Brazil"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Rio de Janeiro");
                cboAttraction.Items.Add("Iguaçu Falls");
                cboAttraction.Items.Add("Ipanema");
                cboAttraction.Items.Add("Amazon Rain Forests");
                cboAttraction.Items.Add("Pernambuco Beaches");
            }
            if (cboCountry.SelectedItem.Equals("Argentina"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Iguazú Falls");
                cboAttraction.Items.Add("Perito Moreno Glacier");
                cboAttraction.Items.Add("Recoleta, La Boca, and Tango in Buenos Aires");
                cboAttraction.Items.Add("Tierra del Fuego National Park");
                cboAttraction.Items.Add("Puerto Madryn and the Valdés Peninsula");
            }
            if (cboCountry.SelectedItem.Equals("Peru"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Machu Picchu");
                cboAttraction.Items.Add("The Inca Trail");
                cboAttraction.Items.Add("Cusco's Architectural Treasures");
                cboAttraction.Items.Add("Lake Titicaca");
                cboAttraction.Items.Add("Nazca Lines");
            }
            if (cboCountry.SelectedItem.Equals("Columbia"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Cartagena");
                cboAttraction.Items.Add("Medellin");
                cboAttraction.Items.Add("Eje Cafetero");
                cboAttraction.Items.Add("Leticia");
                cboAttraction.Items.Add("Tayrona National Natural Park");
            }
            if (cboCountry.SelectedItem.Equals("Chile"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Torres Del Paine National Park");
                cboAttraction.Items.Add("Valle de la Luna and the Atacama Desert");
                cboAttraction.Items.Add("Easter Island & Rapa Nui National Park");
                cboAttraction.Items.Add("Santiago: Chile's Cultural Capital");
                cboAttraction.Items.Add("The Chilean Lake District");
            }
            //oceania
            if (cboCountry.SelectedItem.Equals("Palau"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Peleliu Island, Bloody Nose Ridge");
                cboAttraction.Items.Add("The Belau National Museum");
                cboAttraction.Items.Add("Palau’s Capital: Melekeok and the Ngerulmud");
                cboAttraction.Items.Add("Palau Milky Way, Rock Islands");
                cboAttraction.Items.Add("Stone Monoliths of Ngarchelong");
            }
            if (cboCountry.SelectedItem.Equals("Solomon Islands"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("National Museum of the Solomon Islands");
                cboAttraction.Items.Add("Riba Cave");
                cboAttraction.Items.Add("US War Memorial, Honiara");
                cboAttraction.Items.Add("Lilisiana Village");
                cboAttraction.Items.Add("Marovo Lagoon");
            }
            if (cboCountry.SelectedItem.Equals("Marshall Islands"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Alele Museum");
                cboAttraction.Items.Add("Waan Aelõñ in Majel");
                cboAttraction.Items.Add("Laura Beach Park");
                cboAttraction.Items.Add("Kalalen Pass");
                cboAttraction.Items.Add("The Aquarium, Majuro");
            }
            if (cboCountry.SelectedItem.Equals("Fiji"))
            {
                cboAttraction.Items.Clear();
                cboAttraction.Items.Add("Blue Lagoon Cruise: Mamanuca and Yasawa Islands");
                cboAttraction.Items.Add("Cloudbreak, Mamanuca Islands");
                cboAttraction.Items.Add("Bouma National Heritage Park, Taveuni Island");
                cboAttraction.Items.Add("Denarau Island");
                cboAttraction.Items.Add("Pacific Harbour, Viti Levu");
            }
        }
    }
}