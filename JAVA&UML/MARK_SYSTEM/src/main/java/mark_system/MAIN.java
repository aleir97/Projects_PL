package mark_system;

import java.util.List;
import java.util.ArrayList;
/**
 *
 * @author alejandro
 */
public class MAIN {
    
    public static String getStudent(List<Student> students, int id){
        String rst = null;
        int i;
        
        for(i = 0; i < students.size(); i++){
            if (students.get(i).ID == id){
                rst = students.get(i).Name;
                break;
            }
        }
       
        return rst;
    }
    
    public static String getSubject(List<Subject> subjects, int id){
        String rst = null;
        int i;
        
        for(i = 0; i < subjects.size(); i++){
            if (subjects.get(i).ID == id){
                rst = subjects.get(i).Name;
                break;
            }
        }
       
        return rst;
    }
    
    public static String getTeacher(List<Teacher> teachers, int id){
        String rst = null;
        int i;
        
        for(i = 0; i < teachers.size(); i++){
            if (teachers.get(i).ID == id){
                rst = teachers.get(i).Name;
                break;
            }
        }
       
        return rst;
    }
     
    public static void main(String args[]) {
    
        Student st1 = new Student("Adam Smith", 100);
        Student st2 = new Student("Betty Who", 200);
        Student st3 = new Student("Martin Law", 300);
        List<Student> students = new ArrayList();
        students.add(st1);
        students.add(st2);
        students.add(st3);
        
        Grade g1 = new Grade();
        Grade g2 = new Grade();
        Grade g3 = new Grade();
        Grade g4 = new Grade();
        List<Grade> grades = new ArrayList();
        grades.add(g1);
        grades.add(g2);
        grades.add(g3);
        grades.add(g4);
        
        Subject sub0 = new Subject("Software ENG", 2);
        Subject sub1 = new Subject("Networks", 3);
        List<Subject> subjects = new ArrayList();
        subjects.add(sub0);
        subjects.add(sub1);

        Teacher t1 = new Teacher("Joe Pass", "Software ENG", 200);
        Teacher t2 = new Teacher("Elizabeth", "Networks", 300);
        List<Teacher> teachers = new ArrayList();
        teachers.add(t1);
        teachers.add(t2);
        
        t1.givesGrade(100, 2, "F", g1);
        t2.givesGrade(200, 3, "B", g2);
        t1.givesGrade(300, 3, "A", g3);
        t1.givesGrade(300, 2, "C", g4);
          
        String stchosen = "";
        
        for (Grade aux : grades){
            String stName = getStudent(students,aux.studentID);
            if (stchosen == "" || stchosen ==  stName)
                System.out.printf("%s\t|%s\t|%s\t|%s \n",stName,getTeacher(teachers, aux.teacherID),
                    aux.Mark,getSubject(subjects, aux.subjectID));
        }
        System.out.println("-------------------------------------------------------");
        System.out.println("Showing Chosen Subject:\n");
        String subchosen = "Networks";
        for (Grade aux : grades){
            String subName = getSubject(subjects,aux.subjectID);
            if (subchosen == "" || subchosen ==  subName)
                System.out.printf("%s\t|%s\t|%s\t|%s \n",subName, getStudent(students,aux.studentID), 
                    aux.Mark, getTeacher(teachers, aux.teacherID));
        }     
    }
}
