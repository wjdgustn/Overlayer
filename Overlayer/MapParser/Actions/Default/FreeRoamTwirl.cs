﻿using Overlayer.MapParser.Types;
using JSON;
using static Overlayer.MapParser.Actions.ActionUtils;

namespace Overlayer.MapParser.Actions.Default
{
    public class FreeRoamTwirl : Action
    {
        public Vector2 position = new Vector2(1, 0);
        public FreeRoamTwirl() : base(LevelEventType.FreeRoamTwirl) { }
        public FreeRoamTwirl(Vector2 position, bool active) : base(LevelEventType.FreeRoamTwirl, active)
            => this.position = position;
        public override JsonNode ToNode()
        {
            JsonNode node = InitNode(eventType, active);
            node["position"] = position.ToNode();
            return node;
        }
    }
}
