using UnityEngine;
public class HotbarSlot : MonoBehaviour {

	public KeyCode key;
	Slot slot;

	void Start() {
		slot = GetComponent<Slot>();
	}

	void Update() {
		if( Input.GetKeyDown( key ) ) {
			slot.UseItem();
		}
	}
}
