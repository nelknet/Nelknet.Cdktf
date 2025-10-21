namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamInstanceProfileState = { assignments: ResizeArray<aws.IamInstanceProfile.IamInstanceProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile">aws_iam_instance_profile</a>.
    /// </summary>
    type IamInstanceProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamInstanceProfileState =
            { assignments = ResizeArray() }

        member _.Zero(()) : IamInstanceProfileState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#id-1">IamInstanceProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamInstanceProfileState, value: string) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamInstanceProfileState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#name-1">IamInstanceProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamInstanceProfileState, value: string) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamInstanceProfileState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#name_prefix-1">IamInstanceProfile#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamInstanceProfileState, value: string) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamInstanceProfileState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#path-1">IamInstanceProfile#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamInstanceProfileState, value: string) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamInstanceProfileState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#role-1">IamInstanceProfile#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: IamInstanceProfileState, value: string) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.Role <- value)
            state : IamInstanceProfileState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#tags-1">IamInstanceProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamInstanceProfileState, value: seq<string * string>) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamInstanceProfileState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_instance_profile#tags_all-1">IamInstanceProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamInstanceProfileState, value: seq<string * string>) : IamInstanceProfileState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamInstanceProfileState

        member _.Run(state: IamInstanceProfileState) : aws.IamInstanceProfile.IamInstanceProfile =
            let config = aws.IamInstanceProfile.IamInstanceProfileConfig()
            for setter in state.assignments do
                setter config
            aws.IamInstanceProfile.IamInstanceProfile(StackContext.get (), logicalId, config)
