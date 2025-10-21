namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KendraIndexState<'Name, 'RoleArn> = { assignments: ResizeArray<aws.KendraIndex.KendraIndexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index">aws_kendra_index</a>.
    /// </summary>
    type KendraIndexBuilder(logicalId: string) =
        member _.Yield(_: unit) : KendraIndexState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraIndexState<Missing, Missing>)

        member _.Zero(()) : KendraIndexState<Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraIndexState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#name-1">KendraIndex#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KendraIndexState<Missing, 'RoleArn>, value: string) : KendraIndexState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KendraIndexState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#role_arn-1">KendraIndex#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: KendraIndexState<'Name, Missing>, value: string) : KendraIndexState<'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : KendraIndexState<'Name, Present>)

        /// <summary>
        /// capacity_units block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#capacity_units-1">KendraIndex#capacity_units</a>
        /// </summary>
        [<CustomOperation "capacity_units">]
        member _.CapacityUnits(state: KendraIndexState<'Name, 'RoleArn>, value: aws.KendraIndex.KendraIndexCapacityUnits) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.CapacityUnits <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#description-1">KendraIndex#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KendraIndexState<'Name, 'RoleArn>, value: string) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// document_metadata_configuration_updates block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#document_metadata_configuration_updates-1">KendraIndex#document_metadata_configuration_updates</a> Accepts: aws.IResolvable | aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdates[]
        /// </summary>
        [<CustomOperation "document_metadata_configuration_updates">]
        member _.DocumentMetadataConfigurationUpdates(state: KendraIndexState<'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.DocumentMetadataConfigurationUpdates <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#edition-1">KendraIndex#edition</a>.
        /// </summary>
        [<CustomOperation "edition">]
        member _.Edition(state: KendraIndexState<'Name, 'RoleArn>, value: string) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Edition <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#id-1">KendraIndex#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KendraIndexState<'Name, 'RoleArn>, value: string) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// server_side_encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#server_side_encryption_configuration-1">KendraIndex#server_side_encryption_configuration</a>
        /// </summary>
        [<CustomOperation "server_side_encryption_configuration">]
        member _.ServerSideEncryptionConfiguration(state: KendraIndexState<'Name, 'RoleArn>, value: aws.KendraIndex.KendraIndexServerSideEncryptionConfiguration) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.ServerSideEncryptionConfiguration <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#tags-1">KendraIndex#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KendraIndexState<'Name, 'RoleArn>, value: seq<string * string>) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#tags_all-1">KendraIndex#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KendraIndexState<'Name, 'RoleArn>, value: seq<string * string>) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#timeouts-1">KendraIndex#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KendraIndexState<'Name, 'RoleArn>, value: aws.KendraIndex.KendraIndexTimeouts) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_context_policy-1">KendraIndex#user_context_policy</a>.
        /// </summary>
        [<CustomOperation "user_context_policy">]
        member _.UserContextPolicy(state: KendraIndexState<'Name, 'RoleArn>, value: string) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.UserContextPolicy <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// user_group_resolution_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_group_resolution_configuration-1">KendraIndex#user_group_resolution_configuration</a>
        /// </summary>
        [<CustomOperation "user_group_resolution_configuration">]
        member _.UserGroupResolutionConfiguration(state: KendraIndexState<'Name, 'RoleArn>, value: aws.KendraIndex.KendraIndexUserGroupResolutionConfiguration) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.UserGroupResolutionConfiguration <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        /// <summary>
        /// user_token_configurations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_token_configurations-1">KendraIndex#user_token_configurations</a>
        /// </summary>
        [<CustomOperation "user_token_configurations">]
        member _.UserTokenConfigurations(state: KendraIndexState<'Name, 'RoleArn>, value: aws.KendraIndex.KendraIndexUserTokenConfigurations) : KendraIndexState<'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.UserTokenConfigurations <- value)
            state : KendraIndexState<'Name, 'RoleArn>

        member _.Run(state: KendraIndexState<Present, Present>) : aws.KendraIndex.KendraIndex =
            let config = aws.KendraIndex.KendraIndexConfig()
            for setter in state.assignments do
                setter config
            aws.KendraIndex.KendraIndex(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kendraIndex: missing required arguments. Must call: name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: KendraIndexState<_, _>) : aws.KendraIndex.KendraIndex =
            Unchecked.defaultof<aws.KendraIndex.KendraIndex>
