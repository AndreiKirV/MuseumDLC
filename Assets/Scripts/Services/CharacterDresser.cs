using UnityEngine;

public class CharacterDresser
{
    public CharacterDresser(CharacterOnSceneHolder characterHolder, CharacterChanger characterChanger)
    {
        _characterChanger = characterChanger;
        _characterChanger.ShowNewCharacter += OnShowNewCharacter;

        _characterOnSceneHolder = characterHolder;
        _characterOnSceneHolder.OnInstantiateCharacter += OnInstantiateCharacter;

        ItemIcon.OnDragItemOnCharacterIcon += OnDragItenOnCharacter;
    }

    public CharacterSo CurrentCharacter { get; private set; }
    public CharacterModelMb CurrentCharacterMb { get; private set; }

    private CharacterOnSceneHolder _characterOnSceneHolder;
    private CharacterChanger _characterChanger;
    
    private void OnShowNewCharacter(CharacterSo character) =>
        CurrentCharacter = character;

    private void OnInstantiateCharacter(CharacterModelMb characterMb) =>
        CurrentCharacterMb = characterMb;

    private void OnDragItenOnCharacter(CharacterItemSo itemSo)
    {
        Debug.Log("���������� �� ��������� " + itemSo.name);

        //����� ����� ������� �� ���������
        //����� ������ ������ �� ���������� �������
        //���� ������� ������, �� ���������� �������
        //���� ���� �������, ������� ����� ������ ������, �� ������ ���
    }
}