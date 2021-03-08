package com.sonicscholar;

import java.util.ArrayList;

public class LawnCareProviderAgency {

    ArrayList<ILawnCareProvider> _lawnCareProviders;

    public LawnCareProviderAgency() {
        _lawnCareProviders = new ArrayList<>();
        _lawnCareProviders.add(new SonicScholarLawnCareProvider());
        _lawnCareProviders.add(new MediocreLawnCareProvider());
    }

    public ILawnCareProvider getBestAvailableProvider(){
        ILawnCareProvider result = null;

        int maxRating = 0;
        for (ILawnCareProvider p: _lawnCareProviders) {
            int rating = p.getRating();
            boolean available = p.isAvailable();
            if(rating > maxRating && available)
            {
                maxRating = rating;
                result = p;
            }
        }
        return result;
    }

}
