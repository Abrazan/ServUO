using System;

namespace Server.Items
{
    public class GhostShipAnchor : Item
    {
        [Constructable]
        public GhostShipAnchor()
            : base(0x14F7)
        {
            this.Hue = 0x47E;
            this.Weight = 2;
        }

        public GhostShipAnchor(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1070816;
            }
        }// Ghost Ship Anchor
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 0:
                    this.Weight = 2;
                    break;
            }
            
            if (this.ItemID == 0x1F47)
                this.ItemID = 0x14F7;
        }
    }
}