namespace W6_assignment_template.Interfaces
{
    public interface ICharacter
    {
        void Attack(ICharacter target);
        void Move();
        void PerformSpecialAction();

        string Name { get; set; }

        void DramaticFlair();
    }

}
