package com.sonicscholar;

import java.util.Date;

public abstract class AbstractPerson implements Person{
    private Date _objectCreateTime;
    String _firstName;
    String _lastName;
    Date _dateOfBirth;

    public AbstractPerson() {
        _objectCreateTime = new Date();
    }

    public String getFirstName() { return _firstName; }
    public String getLastName() { return _lastName; }
    public Date getDateOfBirth() {return _dateOfBirth; }

    public abstract String getId();
}
