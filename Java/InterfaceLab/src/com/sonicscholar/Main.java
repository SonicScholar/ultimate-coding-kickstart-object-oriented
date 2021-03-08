package com.sonicscholar;

public class Main {

    public static void main(String[] args) {

        LawnCareProviderAgency agency = new LawnCareProviderAgency();
        ILawnCareProvider provider = agency.getBestAvailableProvider();
        provider.bookWeedRemoval();

        provider = agency.getBestAvailableProvider();
        provider.bookRaking();

        provider = agency.getBestAvailableProvider();
        provider.bookWeedRemoval();

        provider = agency.getBestAvailableProvider();
        provider.bookMowing();

        provider = agency.getBestAvailableProvider();
        provider.bookMowing();





//	    ILawnCareProvider ssLawnProvider = new SonicScholarLawnCareProvider();
//	    ILawnCareProvider mediocreLawnProvider = new MediocreLawnCareProvider();
//
//	    boolean available = ssLawnProvider.isAvailable();
//	    ssLawnProvider.bookMowing();
//	    ssLawnProvider.bookRaking();
//
//	    available = ssLawnProvider.isAvailable();
//	    ssLawnProvider.bookWeedRemoval();
//
//	    available = ssLawnProvider.isAvailable();



    }
}
