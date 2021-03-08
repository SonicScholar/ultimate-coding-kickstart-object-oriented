package com.sonicscholar;

public class SonicScholarLawnCareProvider implements ILawnCareProvider {
    double _totalJobCount;

    public SonicScholarLawnCareProvider(){
        _totalJobCount = 0;
    }

    public void bookMowing(){
        _totalJobCount++;
    }

    public void bookRaking(){
        _totalJobCount++;
    }

    public void bookWeedRemoval(){
        _totalJobCount++;
    }

    public boolean isAvailable(){
        return _totalJobCount < 3;
    }

    public int getRating(){ return 5;}

    public double get_totalJobCount() {
        return _totalJobCount;
    }
}
