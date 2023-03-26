namespace Vidly_MVC_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipTaple : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you Go' WHERE DiscountRate = 0");
            Sql("UPDATE MembershipTypes SET Name = 'monthly' WHERE DiscountRate = 10");
            Sql("UPDATE MembershipTypes SET Name = 'Quartily' WHERE DiscountRate = 15");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE DiscountRate = 20");
        }
        
        public override void Down()
        {
        }
    }
}
