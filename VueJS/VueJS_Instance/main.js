var vueInstance = new Vue({
    el: '#app',
    data: {
        title: "Hello World!",
        counter: 0,
        a: 0,
        b: 0,
        tabSelected: 0
    },
    methods: {
        onUp() {
            return this.counter = this.counter + 1;
        },
        onDown() {
            return t,
            his.counter = this.counter - 1;
        },
        Login() {
            return this.tabSelected = 0;
        },
        Register() {
            return this.tabSelected = 1;
        }
    },
    computed: {
        addA() {
            console.log("Run A");
            return this.a;
        },
        addB() {
            console.log("Run B");
            return this.b;
        },
        
    }
});