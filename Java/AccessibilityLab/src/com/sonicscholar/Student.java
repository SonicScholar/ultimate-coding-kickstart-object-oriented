package com.sonicscholar;

import java.util.Date;

public class Student extends AbstractPerson {
    String _studentId;
    Date _enrollDate;

    public Student(String studentId, String firstName, String lastName)
    {
        _studentId = studentId;
        _firstName = firstName;
        _lastName = lastName;
    }

    @Override
    public String getId() {
        return _studentId;
    }
}
