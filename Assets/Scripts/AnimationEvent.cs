using UnityEngine;

/// <summary>
/// Add an Animation Event to Puppy 3's IdleEvents animation.
/// This is the type of animation seen in the Lab 1 project folder: "2. 3D Animation".
/// </summary>

public class AnimationEvent : MonoBehaviour
{
	[SerializeField] private Animator puppy3Animator;
	[SerializeField] private ParticleSystem magicSpellParticleSystem;
	private float ct;

	private void Update()
	{
		if (Input.GetAxisRaw("Vertical") > 0f) //Walk
		{
			transform.position += new Vector3(Time.deltaTime * 0.3f, 0f);
			puppy3Animator.SetBool("WalkCheck", true);
		}
		else //Idle
		{
			puppy3Animator.SetBool("WalkCheck", false);
			ct += Time.deltaTime;
			if (ct > 3f)
			{
				PuppyMagicSpell();
				ct = 0;
			}
		}
		
	}

	public void PuppyMagicSpell()
	{
		magicSpellParticleSystem.Emit(200);
	}
}
