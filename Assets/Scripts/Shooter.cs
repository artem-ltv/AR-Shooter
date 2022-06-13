using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bullet;

    private void Update()
    {
        if (Input.touchCount > 0)
            if(Input.GetTouch(0).phase == TouchPhase.Began)
                Instantiate(_bullet, _shootPoint);

        if(Input.GetKeyDown(KeyCode.R))
            Instantiate(_bullet, _shootPoint);
    }
}
