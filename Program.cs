List<IDamageable> targets = new()
{
    new Player("Aldric"),
    new Enemy("Goblin"),
    new WoodenCrate(),
    new ExplosiveBarrel()
};

CombatSystem combat = new CombatSystem();

combat.ApplyAreaDamage(targets, 25);   // barel: sisa 15
combat.ApplyAreaDamage(targets, 25);   // barel: meledak