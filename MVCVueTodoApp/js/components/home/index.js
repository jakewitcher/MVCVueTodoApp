import Vue from "vue";
import Todos from "../Todos.vue";

var vm = new Vue({
    el: "#home-app",
    components: {
        'todos': Todos
    }
});