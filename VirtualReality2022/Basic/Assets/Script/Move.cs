using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //public�� ������ ���������� ������ �� ���˴ϴ�. inspectorâ���� Ȯ�ΰ����մϴ�.//
    public float Speed = 1; //int�� ����� �ǹ��մϴ�. ������ Ư���� �����մϴ�. public (���� ����) (���� �̸�) = (��) // float �� ����
    public float RotateX = 10.0f; //�̹����� float�� �־��µ� �Ҽ��� �ǹ��մϴ�. ���� �ڿ� f�� �ֽ��ϴ�.//

    void Start()
    {
        //void start�� ��ũ��Ʈ�� ����Ǹ鼭 ���� ����Ǵ� ������� �ǹ��մϴ�.//
    }
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * RotateX, 0);
    
        //transform�� ��ü�� �����̴� ��ɾ��Դϴ�. rotate�� ȸ���̸� �ڿ� ��ȣ ���� x��, y��, z���� �ǹ��մϴ�. //
        // input.getaxis�� ����Ƽ���� �޾Ƶ��̴� Ư�� Ű ������ mouse x�� ���콺�� x���� �ǹ��ϸ� �� ���� �ռ� ������rotateX���� �����־� �ӵ��� �����մϴ�.//
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");
        //float(�Ҽ�) ������ ���� �����մϴ�. input.getaxis�� horizontal�� Ű������ �¿쳪 ad, ���̽�ƽ�� �¿��Դϴ�. vertical�� �����Դϴ�//
        
        transform.Translate(Vector3.right * Speed * Time.smoothDeltaTime * keyHorizontal);
        transform.Translate(Vector3.forward * Speed * Time.smoothDeltaTime * keyVertical);
        //�ռ� ����� transform�� translate�� �߰��Ͽ� x, y, x ������ �̵��ϰ� �մϴ�. 
        //vector3. �ڿ� ������ �ְ� (left, right, forward, back, up, down)�ű⿡ �ռ� ������ speed���� ���� �� 
        //�ð��� �ӵ�(Time.smoothDeltaTime)�� Ű�Է°��� �����ݴϴ�. ���̽�ƽ�̸� ����ӿ� ���� �ӵ��� �ٲ� �� �ֽ��ϴ�.)
    }
}
