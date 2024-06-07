using UnityEngine;

public class MoveCamera : MonoBehaviour {

    /// Odkaz na transformaci hráče
    public Transform player;

    /// Update je volán jednou za každý snímek. Přesune kameru na pozici hráče
    void Update() {
        transform.position = player.transform.position;
    }
}
