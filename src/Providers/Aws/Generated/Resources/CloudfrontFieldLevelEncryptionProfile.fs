namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name> = { assignments: ResizeArray<aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile">aws_cloudfront_field_level_encryption_profile</a>.
    /// </summary>
    type CloudfrontFieldLevelEncryptionProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontFieldLevelEncryptionProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontFieldLevelEncryptionProfileState<Missing, Missing>)

        member _.Zero(()) : CloudfrontFieldLevelEncryptionProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontFieldLevelEncryptionProfileState<Missing, Missing>)

        /// <summary>
        /// encryption_entities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#encryption_entities-1">CloudfrontFieldLevelEncryptionProfile#encryption_entities</a>
        /// </summary>
        [<CustomOperation "encryption_entities">]
        member _.EncryptionEntities(state: CloudfrontFieldLevelEncryptionProfileState<Missing, 'Name>, value: aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileEncryptionEntities) : CloudfrontFieldLevelEncryptionProfileState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EncryptionEntities <- value)
            ({ assignments = state.assignments } : CloudfrontFieldLevelEncryptionProfileState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#name-1">CloudfrontFieldLevelEncryptionProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, Missing>, value: string) : CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#comment-1">CloudfrontFieldLevelEncryptionProfile#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name>, value: string) : CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#id-1">CloudfrontFieldLevelEncryptionProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name>, value: string) : CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontFieldLevelEncryptionProfileState<'EncryptionEntities, 'Name>

        member _.Run(state: CloudfrontFieldLevelEncryptionProfileState<Present, Present>) : aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfile =
            let config = aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontFieldLevelEncryptionProfile: missing required arguments. Must call: encryption_entities, name.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontFieldLevelEncryptionProfileState<_, _>) : aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfile =
            Unchecked.defaultof<aws.CloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfile>
