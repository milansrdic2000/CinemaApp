namespace Bioskop.Common
{
    public enum Operation
    {
        //login funkcionalnosti
        Login,
        Logout,
        LoginAdmin,
        LogoutAdmin,
        RegisterKorisnik,
        // info o korisniku
        GetKorisnik,


        //Filmovi
        DodajFilm,
        VratiSveFilmove,
        VratiFilm,
        NadjiFilmove,
        IzmeniFilm,

        //Zanrovi
        VratiSveZanrove,
        //Reziseri
        VratiSveRezisere,

        // Bioskopske sale
        DodajBioskopskuSalu,
        VratiSveBioskopskeSale,
        VratiBioskopskuSalu,
        IzmeniBioskopskuSalu,
        NadjiBioskopskeSale,

        //Projekcije Filma
        VratiSveProjekcije,
        DodajProjekciju,
        VratiProjekciju,
        IzmeniProjekciju,
        NadjiProjekcije,

        //rezervacije!!!
        DodajRezervaciju,
        IzmeniRezervaciju,
        VratiSveRezervacije,
        NadjiRezervacije,
        VratiRezervaciju,

        NadjiKarte,

        IsSedisteReservisano,
        VratiSedistaSaDostupnosti

    }
}
