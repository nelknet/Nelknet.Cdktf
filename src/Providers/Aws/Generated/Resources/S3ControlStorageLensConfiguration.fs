namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration> = { assignments: ResizeArray<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration">aws_s3control_storage_lens_configuration</a>.
    /// </summary>
    type S3ControlStorageLensConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlStorageLensConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlStorageLensConfigurationState<Missing, Missing>)

        member _.Zero(()) : S3ControlStorageLensConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlStorageLensConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration#config_id-1">S3ControlStorageLensConfiguration#config_id</a>.
        /// </summary>
        [<CustomOperation "config_id">]
        member _.ConfigId(state: S3ControlStorageLensConfigurationState<Missing, 'StorageLensConfiguration>, value: string) : S3ControlStorageLensConfigurationState<Present, 'StorageLensConfiguration> =
            state.assignments.Add(fun config -> config.ConfigId <- value)
            ({ assignments = state.assignments } : S3ControlStorageLensConfigurationState<Present, 'StorageLensConfiguration>)

        /// <summary>
        /// storage_lens_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration#storage_lens_configuration-1">S3ControlStorageLensConfiguration#storage_lens_configuration</a>
        /// </summary>
        [<CustomOperation "storage_lens_configuration">]
        member _.StorageLensConfiguration(state: S3ControlStorageLensConfigurationState<'ConfigId, Missing>, value: aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationStorageLensConfiguration) : S3ControlStorageLensConfigurationState<'ConfigId, Present> =
            state.assignments.Add(fun config -> config.StorageLensConfiguration <- value)
            ({ assignments = state.assignments } : S3ControlStorageLensConfigurationState<'ConfigId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration#account_id-1">S3ControlStorageLensConfiguration#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>, value: string) : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration#id-1">S3ControlStorageLensConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>, value: string) : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration#tags-1">S3ControlStorageLensConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>, value: seq<string * string>) : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_storage_lens_configuration#tags_all-1">S3ControlStorageLensConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>, value: seq<string * string>) : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : S3ControlStorageLensConfigurationState<'ConfigId, 'StorageLensConfiguration>

        member _.Run(state: S3ControlStorageLensConfigurationState<Present, Present>) : aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfiguration =
            let config = aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlStorageLensConfiguration: missing required arguments. Must call: config_id, storage_lens_configuration.", 9999, IsError = true)>]
        member _.Run(_: S3ControlStorageLensConfigurationState<_, _>) : aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfiguration =
            Unchecked.defaultof<aws.S3ControlStorageLensConfiguration.S3ControlStorageLensConfiguration>
