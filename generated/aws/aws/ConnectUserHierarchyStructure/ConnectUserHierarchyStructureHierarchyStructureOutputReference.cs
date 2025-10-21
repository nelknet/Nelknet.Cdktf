using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectUserHierarchyStructure
{
    [JsiiClass(nativeType: typeof(aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureOutputReference), fullyQualifiedName: "aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConnectUserHierarchyStructureHierarchyStructureOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConnectUserHierarchyStructureHierarchyStructureOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectUserHierarchyStructureHierarchyStructureOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectUserHierarchyStructureHierarchyStructureOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLevelFive", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFive\"}}]")]
        public virtual void PutLevelFive(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFive @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFive)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLevelFour", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFour\"}}]")]
        public virtual void PutLevelFour(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFour @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFour)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLevelOne", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelOne\"}}]")]
        public virtual void PutLevelOne(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelOne @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelOne)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLevelThree", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelThree\"}}]")]
        public virtual void PutLevelThree(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelThree @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelThree)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLevelTwo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwo\"}}]")]
        public virtual void PutLevelTwo(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelTwo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelTwo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLevelFive")]
        public virtual void ResetLevelFive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLevelFour")]
        public virtual void ResetLevelFour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLevelOne")]
        public virtual void ResetLevelOne()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLevelThree")]
        public virtual void ResetLevelThree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLevelTwo")]
        public virtual void ResetLevelTwo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "levelFive", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFiveOutputReference\"}")]
        public virtual aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFiveOutputReference LevelFive
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFiveOutputReference>()!;
        }

        [JsiiProperty(name: "levelFour", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFourOutputReference\"}")]
        public virtual aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFourOutputReference LevelFour
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFourOutputReference>()!;
        }

        [JsiiProperty(name: "levelOne", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelOneOutputReference\"}")]
        public virtual aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelOneOutputReference LevelOne
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelOneOutputReference>()!;
        }

        [JsiiProperty(name: "levelThree", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelThreeOutputReference\"}")]
        public virtual aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelThreeOutputReference LevelThree
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelThreeOutputReference>()!;
        }

        [JsiiProperty(name: "levelTwo", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwoOutputReference\"}")]
        public virtual aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwoOutputReference LevelTwo
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelFiveInput", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFive\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFive? LevelFiveInput
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFive?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelFourInput", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelFour\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFour? LevelFourInput
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelFour?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelOneInput", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelOne\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelOne? LevelOneInput
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelOne?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelThreeInput", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelThree\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelThree? LevelThreeInput
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelThree?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "levelTwoInput", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureLevelTwo\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelTwo? LevelTwoInput
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructureLevelTwo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructure\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructure? InternalValue
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructure?>();
            set => SetInstanceProperty(value);
        }
    }
}
