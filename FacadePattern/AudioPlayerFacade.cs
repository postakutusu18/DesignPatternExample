namespace FacadePattern;

public class AudioPlayerFacade
{
    private readonly AudioFile _audioFile;
    private readonly Codec _codec;
    private readonly Player _player;

    public AudioPlayerFacade()
    {
        _audioFile = new AudioFile();
        _codec = new Codec();
        _player = new Player();
    }

    public void PlayAudio(string fileName)
    {
        _audioFile.LoadFile(fileName);
        _codec.DecodeFile(fileName);
        _player.Play(fileName);
    }
}
