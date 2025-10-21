namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EfsFileSystemState = { assignments: ResizeArray<aws.EfsFileSystem.EfsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system">aws_efs_file_system</a>.
    /// </summary>
    type EfsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : EfsFileSystemState =
            { assignments = ResizeArray() }

        member _.Zero(()) : EfsFileSystemState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#availability_zone_name-1">EfsFileSystem#availability_zone_name</a>.
        /// </summary>
        [<CustomOperation "availability_zone_name">]
        member _.AvailabilityZoneName(state: EfsFileSystemState, value: string) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.AvailabilityZoneName <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#creation_token-1">EfsFileSystem#creation_token</a>.
        /// </summary>
        [<CustomOperation "creation_token">]
        member _.CreationToken(state: EfsFileSystemState, value: string) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.CreationToken <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#encrypted-1">EfsFileSystem#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EfsFileSystemState, value: bool) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#encrypted-1">EfsFileSystem#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EfsFileSystemState, value: HashiCorp.Cdktf.IResolvable) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#id-1">EfsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EfsFileSystemState, value: string) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#kms_key_id-1">EfsFileSystem#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: EfsFileSystemState, value: string) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : EfsFileSystemState

        /// <summary>
        /// lifecycle_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#lifecycle_policy-1">EfsFileSystem#lifecycle_policy</a> Accepts: aws.IResolvable | aws.EfsFileSystem.EfsFileSystemLifecyclePolicy[]
        /// </summary>
        [<CustomOperation "lifecycle_policy">]
        member _.LifecyclePolicy(state: EfsFileSystemState, value: HashiCorp.Cdktf.IResolvable) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.LifecyclePolicy <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#performance_mode-1">EfsFileSystem#performance_mode</a>.
        /// </summary>
        [<CustomOperation "performance_mode">]
        member _.PerformanceMode(state: EfsFileSystemState, value: string) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.PerformanceMode <- value)
            state : EfsFileSystemState

        /// <summary>
        /// protection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#protection-1">EfsFileSystem#protection</a>
        /// </summary>
        [<CustomOperation "protection">]
        member _.Protection(state: EfsFileSystemState, value: aws.EfsFileSystem.EfsFileSystemProtection) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.Protection <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#provisioned_throughput_in_mibps-1">EfsFileSystem#provisioned_throughput_in_mibps</a>.
        /// </summary>
        [<CustomOperation "provisioned_throughput_in_mibps">]
        member _.ProvisionedThroughputInMibps(state: EfsFileSystemState, value: double) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.ProvisionedThroughputInMibps <- value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#tags-1">EfsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EfsFileSystemState, value: seq<string * string>) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#tags_all-1">EfsFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EfsFileSystemState, value: seq<string * string>) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_file_system#throughput_mode-1">EfsFileSystem#throughput_mode</a>.
        /// </summary>
        [<CustomOperation "throughput_mode">]
        member _.ThroughputMode(state: EfsFileSystemState, value: string) : EfsFileSystemState =
            state.assignments.Add(fun config -> config.ThroughputMode <- value)
            state : EfsFileSystemState

        member _.Run(state: EfsFileSystemState) : aws.EfsFileSystem.EfsFileSystem =
            let config = aws.EfsFileSystem.EfsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.EfsFileSystem.EfsFileSystem(StackContext.get (), logicalId, config)
