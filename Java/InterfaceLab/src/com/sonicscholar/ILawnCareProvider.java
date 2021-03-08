package com.sonicscholar;

public interface ILawnCareProvider {
    void bookMowing();
    void bookRaking();
    void bookWeedRemoval();
    boolean isAvailable();
    int getRating();
}
