using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Exam")]
public class ExamQuestions : ScriptableObject
{
    
    public List<PluralQus> pluralQus = new List<PluralQus>();
    public List<SubjectivityQus> subjectivityQus = new List<SubjectivityQus>();

}