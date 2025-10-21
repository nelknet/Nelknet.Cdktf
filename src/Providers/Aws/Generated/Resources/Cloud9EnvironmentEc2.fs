namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> = { assignments: ResizeArray<aws.Cloud9EnvironmentEc2.Cloud9EnvironmentEc2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2">aws_cloud9_environment_ec2</a>.
    /// </summary>
    type Cloud9EnvironmentEc2Builder(logicalId: string) =
        member _.Yield(_: unit) : Cloud9EnvironmentEc2State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Cloud9EnvironmentEc2State<Missing, Missing, Missing>)

        member _.Zero(()) : Cloud9EnvironmentEc2State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Cloud9EnvironmentEc2State<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#image_id-1">Cloud9EnvironmentEc2#image_id</a>.
        /// </summary>
        [<CustomOperation "image_id">]
        member _.ImageId(state: Cloud9EnvironmentEc2State<Missing, 'InstanceType, 'Name>, value: string) : Cloud9EnvironmentEc2State<Present, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ImageId <- value)
            ({ assignments = state.assignments } : Cloud9EnvironmentEc2State<Present, 'InstanceType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#instance_type-1">Cloud9EnvironmentEc2#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: Cloud9EnvironmentEc2State<'ImageId, Missing, 'Name>, value: string) : Cloud9EnvironmentEc2State<'ImageId, Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : Cloud9EnvironmentEc2State<'ImageId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#name-1">Cloud9EnvironmentEc2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, Missing>, value: string) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#automatic_stop_time_minutes-1">Cloud9EnvironmentEc2#automatic_stop_time_minutes</a>.
        /// </summary>
        [<CustomOperation "automatic_stop_time_minutes">]
        member _.AutomaticStopTimeMinutes(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: double) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.AutomaticStopTimeMinutes <- value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#connection_type-1">Cloud9EnvironmentEc2#connection_type</a>.
        /// </summary>
        [<CustomOperation "connection_type">]
        member _.ConnectionType(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: string) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionType <- value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#description-1">Cloud9EnvironmentEc2#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: string) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#id-1">Cloud9EnvironmentEc2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: string) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#owner_arn-1">Cloud9EnvironmentEc2#owner_arn</a>.
        /// </summary>
        [<CustomOperation "owner_arn">]
        member _.OwnerArn(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: string) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.OwnerArn <- value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#subnet_id-1">Cloud9EnvironmentEc2#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: string) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#tags-1">Cloud9EnvironmentEc2#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: seq<string * string>) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_ec2#tags_all-1">Cloud9EnvironmentEc2#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>, value: seq<string * string>) : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Cloud9EnvironmentEc2State<'ImageId, 'InstanceType, 'Name>

        member _.Run(state: Cloud9EnvironmentEc2State<Present, Present, Present>) : aws.Cloud9EnvironmentEc2.Cloud9EnvironmentEc2 =
            let config = aws.Cloud9EnvironmentEc2.Cloud9EnvironmentEc2Config()
            for setter in state.assignments do
                setter config
            aws.Cloud9EnvironmentEc2.Cloud9EnvironmentEc2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloud9EnvironmentEc2: missing required arguments. Must call: image_id, instance_type, name.", 9999, IsError = true)>]
        member _.Run(_: Cloud9EnvironmentEc2State<_, _, _>) : aws.Cloud9EnvironmentEc2.Cloud9EnvironmentEc2 =
            Unchecked.defaultof<aws.Cloud9EnvironmentEc2.Cloud9EnvironmentEc2>
