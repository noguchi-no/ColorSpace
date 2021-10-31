using UnityEngine;
using System.Runtime.InteropServices;

public class IDFA : MonoBehaviour
{

#if UNITY_IOS//iOS�̏ꍇ��������

    //MyObjc.mm �Œ�`���Ă���Objective-C(iOS�Ŏg�p����Ă��錾��)�̊֐����ȉ��̂悤��C#���Œ�`����
    [DllImport("__Internal")]//iOS�̃v���O�C���ǂݍ��� �Q�l�@https://docs.unity3d.com/ja/2018.4/Manual/NativePlugins.html
    private static extern void _requestIDFA();//�O���Ŏ�������郁�\�b�h��錾 �Q�l�@https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/extern

#endif//iOS�̏����͈͏I���


    private void Start()
    {
        Invoke("DelayIDFA", 1);//1�b�x�点��DelayIDFA()�̌Ăяo���@(iOS15�ł͒x�������Ȃ��ƕ\������Ȃ�����)
    }


    private void DelayIDFA()
    {
#if UNITY_IOS//iOS�̏ꍇ��������

        _requestIDFA();//IDFA���N�G�X�g�̎��s
        
#endif//iOS�̏����͈͏I���
    }

}