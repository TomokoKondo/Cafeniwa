using UnityEngine;
using System.Collections;

public class User : MonoBehaviour {
  private int id;
  private string name;
  private string role;
  private int auth;

  public User() {
	}

  public User(int id, string name, string role, int auth) {
    this.id = id;
    this.name = name;
    this.role = role;
    this.auth = auth;
  }

  public void setId(int id) {
    this.id = id;
  }

  public void setName(string name) {
    this.name = name;
  }

  public void setRole(string role) {
    this.role = role;
  }

  public void setAuth(int auth) {
    this.auth = auth;
  }

  public int getId() {
    return id;
  }

  public string getName() {
        return name;
  }

  public string getRole() {
      return role;
  }

  public int getAuth() {
      return auth;
  }
}
