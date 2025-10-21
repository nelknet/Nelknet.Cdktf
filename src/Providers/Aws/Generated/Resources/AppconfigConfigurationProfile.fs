namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> = { assignments: ResizeArray<aws.AppconfigConfigurationProfile.AppconfigConfigurationProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile">aws_appconfig_configuration_profile</a>.
    /// </summary>
    type AppconfigConfigurationProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppconfigConfigurationProfileState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigConfigurationProfileState<Missing, Missing, Missing>)

        member _.Zero(()) : AppconfigConfigurationProfileState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppconfigConfigurationProfileState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#application_id-1">AppconfigConfigurationProfile#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: AppconfigConfigurationProfileState<Missing, 'LocationUri, 'Name>, value: string) : AppconfigConfigurationProfileState<Present, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : AppconfigConfigurationProfileState<Present, 'LocationUri, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#location_uri-1">AppconfigConfigurationProfile#location_uri</a>.
        /// </summary>
        [<CustomOperation "location_uri">]
        member _.LocationUri(state: AppconfigConfigurationProfileState<'ApplicationId, Missing, 'Name>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LocationUri <- value)
            ({ assignments = state.assignments } : AppconfigConfigurationProfileState<'ApplicationId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#name-1">AppconfigConfigurationProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, Missing>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#description-1">AppconfigConfigurationProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#id-1">AppconfigConfigurationProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#kms_key_identifier-1">AppconfigConfigurationProfile#kms_key_identifier</a>.
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#retrieval_role_arn-1">AppconfigConfigurationProfile#retrieval_role_arn</a>.
        /// </summary>
        [<CustomOperation "retrieval_role_arn">]
        member _.RetrievalRoleArn(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.RetrievalRoleArn <- value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#tags-1">AppconfigConfigurationProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: seq<string * string>) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#tags_all-1">AppconfigConfigurationProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: seq<string * string>) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#type-1">AppconfigConfigurationProfile#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: string) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        /// <summary>
        /// validator block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#validator-1">AppconfigConfigurationProfile#validator</a> Accepts: aws.IResolvable | aws.AppconfigConfigurationProfile.AppconfigConfigurationProfileValidator[]
        /// </summary>
        [<CustomOperation "validator">]
        member _.Validator(state: AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name> =
            state.assignments.Add(fun config -> config.Validator <- value)
            state : AppconfigConfigurationProfileState<'ApplicationId, 'LocationUri, 'Name>

        member _.Run(state: AppconfigConfigurationProfileState<Present, Present, Present>) : aws.AppconfigConfigurationProfile.AppconfigConfigurationProfile =
            let config = aws.AppconfigConfigurationProfile.AppconfigConfigurationProfileConfig()
            for setter in state.assignments do
                setter config
            aws.AppconfigConfigurationProfile.AppconfigConfigurationProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appconfigConfigurationProfile: missing required arguments. Must call: application_id, location_uri, name.", 9999, IsError = true)>]
        member _.Run(_: AppconfigConfigurationProfileState<_, _, _>) : aws.AppconfigConfigurationProfile.AppconfigConfigurationProfile =
            Unchecked.defaultof<aws.AppconfigConfigurationProfile.AppconfigConfigurationProfile>
