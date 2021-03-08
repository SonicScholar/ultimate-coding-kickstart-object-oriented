package com.sonicscholar;

public class MediocreLawnCareProvider implements ILawnCareProvider{

    @Override
    public void bookMowing() {

    }

    @Override
    public void bookRaking() {

    }

    @Override
    public void bookWeedRemoval() {

    }

    @Override
    public boolean isAvailable() {
        return true;
    }

    @Override
    public int getRating() {
        return 3;
    }
}
