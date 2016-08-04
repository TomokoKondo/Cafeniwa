using UnityEngine;
using System.Collections;

public class Coupon : MonoBehaviour {
	private int id;
	private string name;
	private int level;
	private int cafe_id;
	private int used;

	public Coupon(int id, string name, int level, int cafe_id, int used){
			this.id = id;
			this.name = name;
			this.level = level;
			this.cafe_id = cafe_id;
			this.used = used;
	}


  public int getId(){
      return id;
  }

  public string getName(){
      return name;
  }

  public int getLevel(){
      return level;
  }

  public int getCafeId(){
      return cafe_id;
  }

  public int getUsed(){
      return used;
  }
}
