#pragma strict
var anim:Animator;

function Start () {

}

function Update () {
if(Input.GetKeyDown(KeyCode.T)){
Talk();
}
}

function Talk(){
anim.SetBool("Audio", true);
audio.Play();
yield WaitForSeconds(audio.clip.length);
anim.SetBool("Audio", false);
}
