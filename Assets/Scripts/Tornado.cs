using System.Collections;
using UnityEngine;

public class Tornado : MonoBehaviour {
    [SerializeField] private Transform _pointParent;
    [SerializeField] private float _beforeStartDelay;
    [SerializeField] private float _activeTime;
    [SerializeField] private float _pause;
    [SerializeField] private float _speed;

    private Transform[] _points;
    private Transform _thisTransform;
    
    private void Awake() {
        _thisTransform = transform;
        _points = new Transform[_pointParent.childCount];
        for (int childId = 0; childId < _points.Length; childId++) {
            _points[childId] = _pointParent.GetChild(childId);
        }
    }

    private void Start() => StartCoroutine(ShowAnim());

    private IEnumerator ShowAnim() {
        yield return new WaitForSeconds(_beforeStartDelay);

        for (float frameId = 0; frameId < 1; frameId += 0.01f) {
            _thisTransform.localScale = Vector3.one * frameId;
            yield return new WaitForFixedUpdate();
        }

        StartCoroutine(Disabler());

        while (true) {
            int pointId = Random.Range(0, _points.Length);
            Vector3 endPosition = _points[pointId].position;
            float distance = Vector3.Distance(_thisTransform.position, endPosition);
            int frames = (int)(distance / _speed);

            //Debug.LogError($"{_points.Length}");
            //Debug.LogError($"{pointId} = {endPosition}");
            
            for (int frameId = 0; frameId < frames; frameId++) {
                _thisTransform.position = Vector3.MoveTowards(_thisTransform.position, endPosition, _speed);
                yield return new WaitForEndOfFrame();
            }
        }
    }

    private IEnumerator Disabler() {
        yield return new WaitForSeconds(_activeTime);
        StopTornado();
    }

    private void StopTornado() {
        StopAllCoroutines();
        StartCoroutine(DisableAnim());
    }

    private IEnumerator DisableAnim() {
        for (float frameId = 1; frameId > 0; frameId -= 0.01f) {
            _thisTransform.localScale = Vector3.one * frameId;
            yield return new WaitForFixedUpdate();
        }
        yield return new WaitForSeconds(_pause);
        StartCoroutine(ShowAnim());
    }
}
