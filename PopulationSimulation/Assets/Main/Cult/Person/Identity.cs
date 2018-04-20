using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Identity : MonoBehaviour {

    public new string name = "Elsa";
    public Gender gender = Gender.FEMALE;
    public AgeGroup AgeGroup = AgeGroup.YOUNGADULT;
}

public enum Gender {MALE,FEMALE}
public enum AgeGroup { CHILD, TEEN,YOUNGADULT,ADULT,ELDERLY }