namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LaunchConfigurationState<'ImageId, 'InstanceType> = { assignments: ResizeArray<aws.LaunchConfiguration.LaunchConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration">aws_launch_configuration</a>.
    /// </summary>
    type LaunchConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LaunchConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LaunchConfigurationState<Missing, Missing>)

        member _.Zero(()) : LaunchConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LaunchConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#image_id-1">LaunchConfiguration#image_id</a>.
        /// </summary>
        [<CustomOperation "image_id">]
        member _.ImageId(state: LaunchConfigurationState<Missing, 'InstanceType>, value: string) : LaunchConfigurationState<Present, 'InstanceType> =
            state.assignments.Add(fun config -> config.ImageId <- value)
            ({ assignments = state.assignments } : LaunchConfigurationState<Present, 'InstanceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#instance_type-1">LaunchConfiguration#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: LaunchConfigurationState<'ImageId, Missing>, value: string) : LaunchConfigurationState<'ImageId, Present> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : LaunchConfigurationState<'ImageId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#associate_public_ip_address-1">LaunchConfiguration#associate_public_ip_address</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_public_ip_address">]
        member _.AssociatePublicIpAddress(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: bool) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.AssociatePublicIpAddress <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#associate_public_ip_address-1">LaunchConfiguration#associate_public_ip_address</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "associate_public_ip_address">]
        member _.AssociatePublicIpAddress(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.AssociatePublicIpAddress <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// ebs_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#ebs_block_device-1">LaunchConfiguration#ebs_block_device</a> Accepts: aws.IResolvable | aws.LaunchConfiguration.LaunchConfigurationEbsBlockDevice[]
        /// </summary>
        [<CustomOperation "ebs_block_device">]
        member _.EbsBlockDevice(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsBlockDevice <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#ebs_optimized-1">LaunchConfiguration#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: bool) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#ebs_optimized-1">LaunchConfiguration#ebs_optimized</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ebs_optimized">]
        member _.EbsOptimized(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EbsOptimized <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#enable_monitoring-1">LaunchConfiguration#enable_monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_monitoring">]
        member _.EnableMonitoring(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: bool) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EnableMonitoring <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#enable_monitoring-1">LaunchConfiguration#enable_monitoring</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_monitoring">]
        member _.EnableMonitoring(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EnableMonitoring <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// ephemeral_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#ephemeral_block_device-1">LaunchConfiguration#ephemeral_block_device</a> Accepts: aws.IResolvable | aws.LaunchConfiguration.LaunchConfigurationEphemeralBlockDevice[]
        /// </summary>
        [<CustomOperation "ephemeral_block_device">]
        member _.EphemeralBlockDevice(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: HashiCorp.Cdktf.IResolvable) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.EphemeralBlockDevice <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#iam_instance_profile-1">LaunchConfiguration#iam_instance_profile</a>.
        /// </summary>
        [<CustomOperation "iam_instance_profile">]
        member _.IamInstanceProfile(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.IamInstanceProfile <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#id-1">LaunchConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#key_name-1">LaunchConfiguration#key_name</a>.
        /// </summary>
        [<CustomOperation "key_name">]
        member _.KeyName(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.KeyName <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// metadata_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#metadata_options-1">LaunchConfiguration#metadata_options</a>
        /// </summary>
        [<CustomOperation "metadata_options">]
        member _.MetadataOptions(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: aws.LaunchConfiguration.LaunchConfigurationMetadataOptions) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.MetadataOptions <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#name-1">LaunchConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#name_prefix-1">LaunchConfiguration#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#placement_tenancy-1">LaunchConfiguration#placement_tenancy</a>.
        /// </summary>
        [<CustomOperation "placement_tenancy">]
        member _.PlacementTenancy(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.PlacementTenancy <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// root_block_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#root_block_device-1">LaunchConfiguration#root_block_device</a>
        /// </summary>
        [<CustomOperation "root_block_device">]
        member _.RootBlockDevice(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: aws.LaunchConfiguration.LaunchConfigurationRootBlockDevice) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.RootBlockDevice <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#security_groups-1">LaunchConfiguration#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: seq<string>) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#spot_price-1">LaunchConfiguration#spot_price</a>.
        /// </summary>
        [<CustomOperation "spot_price">]
        member _.SpotPrice(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.SpotPrice <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#user_data-1">LaunchConfiguration#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_configuration#user_data_base64-1">LaunchConfiguration#user_data_base64</a>.
        /// </summary>
        [<CustomOperation "user_data_base64">]
        member _.UserDataBase64(state: LaunchConfigurationState<'ImageId, 'InstanceType>, value: string) : LaunchConfigurationState<'ImageId, 'InstanceType> =
            state.assignments.Add(fun config -> config.UserDataBase64 <- value)
            state : LaunchConfigurationState<'ImageId, 'InstanceType>

        member _.Run(state: LaunchConfigurationState<Present, Present>) : aws.LaunchConfiguration.LaunchConfiguration =
            let config = aws.LaunchConfiguration.LaunchConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.LaunchConfiguration.LaunchConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.launchConfiguration: missing required arguments. Must call: image_id, instance_type.", 9999, IsError = true)>]
        member _.Run(_: LaunchConfigurationState<_, _>) : aws.LaunchConfiguration.LaunchConfiguration =
            Unchecked.defaultof<aws.LaunchConfiguration.LaunchConfiguration>
