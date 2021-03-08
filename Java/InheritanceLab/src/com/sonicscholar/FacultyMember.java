package com.sonicscholar;

import java.util.Date;

public class FacultyMember extends AbstractPerson {
    String _facultyId;
    Date _dateOfHire;
    boolean _isTenured;

    public FacultyMember(String facultyId, String firstName, String lastName)
    {
        super();
        _facultyId = facultyId;
        _firstName = firstName;
        _lastName = lastName;
    }

    @Override
    public String getId(){
        return _facultyId;
    }
}
