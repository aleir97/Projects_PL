package mark_system;

import java.util.List;
import java.util.ArrayList;
/**
 *
 * @author alejandro
 */
public class MAIN {
    
    public static void main(String args[]) {
    
        Student st1 = new Student("Adam Smith", 100);
        Student st2 = new Student("Betty Who", 200);
        List<Student> students = new ArrayList();

        students.add(st1);
        students.add(st2);

        Teacher t1 = new Teacher("Joe Pass", "Software ENG", 200);

        Grade g1 = new Grade();
        Grade g2 = new Grade();
        List<Grade> grades = new ArrayList();
        grades.add(g1);
        grades.add(g2);

        t1.givesGrade(100, 1, "F", g1);
        t1.givesGrade(100, 1, "B", g2);

        for (Grade aux : grades){
            System.out.printf("%d %d %s \n",aux.studentID, aux.subjectID, aux.Mark);

        }

        for (Student aux : students){
            System.out.printf("%d %s \n",aux.ID, aux.Name);

        }
    }
}
