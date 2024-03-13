package dockerfile

# Disallow using the "latest" tag for images
disallow_latest_tag[msg] {
    some i
    input[i].Cmd == "from"
    val := input[i].Value
    endswith(val[0], ":latest")
    msg := sprintf("Docker image '%s' uses the 'latest' tag, which is discouraged.", [val[0]])
}

# Require that a MAINTAINER label is specified
require_maintainer_label[msg] {
    not has_maintainer_label
    msg := "Dockerfile must include a 'MAINTAINER' label."
}

has_maintainer_label {
    some i
    input[i].Cmd == "label"
    val := input[i].Value
    startswith(val[0], "MAINTAINER")
}
