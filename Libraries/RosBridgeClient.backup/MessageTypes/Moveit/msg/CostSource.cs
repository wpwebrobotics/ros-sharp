/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class CostSource : Message
    {
        public const string RosMessageName = "moveit_msgs/CostSource";

        //  The density of the cost source
        public double cost_density { get; set; }
        //  The volume of the cost source is represented as an
        //  axis-aligned bounding box (AABB)
        //  The AABB is specified by two of its opposite corners
        public Vector3 aabb_min { get; set; }
        public Vector3 aabb_max { get; set; }

        public CostSource()
        {
            this.cost_density = 0.0;
            this.aabb_min = new Vector3();
            this.aabb_max = new Vector3();
        }

        public CostSource(double cost_density, Vector3 aabb_min, Vector3 aabb_max)
        {
            this.cost_density = cost_density;
            this.aabb_min = aabb_min;
            this.aabb_max = aabb_max;
        }
    }
}
