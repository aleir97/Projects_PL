package mark_system;

/**
 *
 * @author alejandro
 */
public class Teacher extends Person {
    
    public String field_study;
    public int ID;

    public Teacher(String  name, String f_d, int id){
        super(name);
        this.field_study = f_d;
        this.ID = id;
    }
    
    public void givesGrade(int studId, int subId, String m, Grade grade){
        grade.studentID = studId;
        grade.subjectID = subId;
        grade.Mark = m;
        grade.teacherID = this.ID;
    }
}
