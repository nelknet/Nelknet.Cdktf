using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectUserHierarchyGroup
{
    [JsiiClass(nativeType: typeof(aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathOutputReference), fullyQualifiedName: "aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConnectUserHierarchyGroupHierarchyPathOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ConnectUserHierarchyGroupHierarchyPathOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectUserHierarchyGroupHierarchyPathOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectUserHierarchyGroupHierarchyPathOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "levelFive", typeJson: "{\"fqn\":\"aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelFiveList\"}")]
        public virtual aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelFiveList LevelFive
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelFiveList>()!;
        }

        [JsiiProperty(name: "levelFour", typeJson: "{\"fqn\":\"aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelFourList\"}")]
        public virtual aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelFourList LevelFour
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelFourList>()!;
        }

        [JsiiProperty(name: "levelOne", typeJson: "{\"fqn\":\"aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelOneList\"}")]
        public virtual aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelOneList LevelOne
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelOneList>()!;
        }

        [JsiiProperty(name: "levelThree", typeJson: "{\"fqn\":\"aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelThreeList\"}")]
        public virtual aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelThreeList LevelThree
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelThreeList>()!;
        }

        [JsiiProperty(name: "levelTwo", typeJson: "{\"fqn\":\"aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelTwoList\"}")]
        public virtual aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelTwoList LevelTwo
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPathLevelTwoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connectUserHierarchyGroup.ConnectUserHierarchyGroupHierarchyPath\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyGroup.IConnectUserHierarchyGroupHierarchyPath? InternalValue
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyGroup.IConnectUserHierarchyGroupHierarchyPath?>();
            set => SetInstanceProperty(value);
        }
    }
}
