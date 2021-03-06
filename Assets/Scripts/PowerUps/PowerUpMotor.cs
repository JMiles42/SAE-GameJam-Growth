﻿public class PowerUpMotor: WorldObject
{
	public PowerUpBase PowerUp;

	protected override void OnEnable()
	{
		base.OnEnable();
		OnPlayerInteraction += PlayerInteraction;
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		OnPlayerInteraction -= PlayerInteraction;
	}

	private void PlayerInteraction(Motor motor)
	{
		motor.AddPowerUp(PowerUp);
	}
}
